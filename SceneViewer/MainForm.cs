using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AssetStudio;
using AssetObject = AssetStudio.Object;
using OpenFolderDialog = AssetStudioGUI.OpenFolderDialog;

namespace SceneViewer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            Logger.Default = new GUILogger() {
                LogEvent = new Action<string>(delegate (string msg) {
                    if (InvokeRequired)
                        BeginInvoke(new Action(delegate { toolStripStatusLabel1.Text = msg; }));
                    else
                        toolStripStatusLabel1.Text = msg;
                })
            };
            Progress.Default = new GUIProgress() {
                reportEvent = new Action<int>(delegate (int val) {
                    if (InvokeRequired)
                        BeginInvoke(new Action(delegate { toolStripProgressBar1.Value = val; }));
                    else
                        toolStripProgressBar1.Value = val;
                })
            };

            manager = new AssetsManager();
            scriptDumper = new ScriptDumper();
            openFileDialog.Multiselect = false;
        }

        private AssetsManager manager;
        private ScriptDumper scriptDumper;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private OpenFolderDialog openFolderDialog = new OpenFolderDialog();


        // 加载和列表刷新
        private void 加载文件ToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.Title = "打开文件";
            openFileDialog.DefaultExt = "*.*|所有文件";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                menuStrip1.Enabled = false;
                tabControl1.Enabled = false;
                ClearForm();
                ThreadPool.QueueUserWorkItem(delegate {
                    manager.LoadFiles(openFileDialog.FileName);
                    BeginInvoke(new Action(delegate { AfterLoad(); }));
                });
            }
        }

        private void 加载文件夹ToolStripMenuItem_Click(object sender, EventArgs e) {
            openFolderDialog.Title = "打开Data文件夹";
            if (openFolderDialog.ShowDialog(this) == DialogResult.OK) {
                menuStrip1.Enabled = false;
                tabControl1.Enabled = false;
                ClearForm();
                ThreadPool.QueueUserWorkItem(delegate {
                    manager.LoadFolder(openFolderDialog.Folder);
                    BeginInvoke(new Action(delegate { AfterLoad(); }));
                });
            }
        }

        private void AfterLoad() {
            if (manager.assetsFileList.Count > 0) {
                Text = "Version: " + manager.assetsFileList[0].unityVersion;

                // 加载文件视图
                Logger.Info("加载文件视图");
                Progress.Reset();
                int proRate = 0;
                foreach (var assetFile in manager.assetsFileList) {
                    FileView_Selector.Items.Add(assetFile.fileName);
                    Progress.Report(++proRate, manager.assetsFileList.Count);
                }
                Logger.Info("加载文件视图完成");

                // 加载场景视图
                Logger.Info("加载场景视图");
                Progress.Reset();
                proRate = 0;
                foreach (var file in manager.assetsFileList) {
                    var node = file.BuildHierarchiesTree();
                    if (node.Nodes.Count > 0)
                        HierarchiesTree.Nodes.Add(node);
                    Progress.Report(++proRate, manager.assetsFileList.Count);
                }
                Logger.Info("加载场景视图完成");


                // TODO 加载脚本视图
                Logger.Info("加载脚本视图");

                Logger.Info("视图更新完成");
            } else {
                Logger.Info("未找到Unity资源文件");
            }
            menuStrip1.Enabled = true;
            tabControl1.Enabled = true;
        }

        private void ClearForm() {
            // 场景视图
            HierarchiesTree.Nodes.Clear();
            ComponentTree.Nodes.Clear();

            // 文件视图
            FileView_Selector.Items.Clear();
            ExternalList.Items.Clear();
            AssetObjList.Items.Clear();

            // 右侧视图
            DumpText.Text = "";
            FileInfoText.Text = "";

            Text = "MainForm";

            manager.Clear();
            scriptDumper.Dispose();
            scriptDumper = new ScriptDumper();
        }

        // 场景视图部分
        private void HierarchiesTree_AfterSelect(object sender, TreeViewEventArgs e) {
            if (HierarchiesTree.SelectedNode.Tag is GameObject gameObject) {
                ShowInfoForObj(gameObject);
                Logger.Info("获取组件");
                ComponentTree.Nodes.Clear();
                ComponentTree.Nodes.AddRange(gameObject.BuildComponentsList());
                Logger.Info("获取组件完成");
            }
        }

        private void ComponentTree_AfterSelect(object sender, TreeViewEventArgs e) {
            var obj = ComponentTree.SelectedNode.Tag as AssetObject;
            ShowInfoForObj(obj);
        }
        
        // 文件视图部分
        private void FileView_Selector_SelectedIndexChanged(object sender, EventArgs e) {
            ExternalList.Items.Clear();
            AssetObjList.Items.Clear();
            var file = manager.assetsFileList[FileView_Selector.SelectedIndex];
            for (int i = 0; i < file.m_Externals.Count; i++) {
                ListViewItem item = new ListViewItem() {
                    Tag = i,
                    Text = string.Format("{0} (0x{0:X})", i, i)
                };
                item.SubItems.Add(file.m_Externals[i].fileName);
                ExternalList.Items.Add(item);
            }
            foreach (var obj in file.Objects) {
                ListViewItem item = new ListViewItem() {
                    Tag = obj.Value,
                    Text = string.Format("{0} (0x{0:X})", obj.Key, obj.Key) 
                };
                item.SubItems.Add(obj.Value.type.ToString());
                AssetObjList.Items.Add(item);
            }
        }

        private void AssetObjList_SelectedIndexChanged(object sender, EventArgs e) {
            if (AssetObjList.SelectedItems.Count > 0)
                ShowInfoForObj(AssetObjList.SelectedItems[0].Tag as AssetObject);
        }

        // 右侧信息展示
        private void ShowInfoForObj(AssetObject assetObject) {
            if (assetObject is MonoBehaviour)
                DumpText.Text = scriptDumper.DumpScript(assetObject.reader);
            else
                DumpText.Text = assetObject.DumpObjInfo();
            FileInfoText.Text = assetObject.DumpFileInfo();
        }

        // 加载DLL
        private void 加载DLLToolStripMenuItem_Click(object sender, EventArgs e) {
            if (manager.assetsFileList.Count > 0) {
                openFolderDialog.Title = "打开DLL所在文件夹";
                if (openFolderDialog.ShowDialog(this) == DialogResult.OK) {
                    Logger.Info("载入DLL");
                    scriptDumper.Dispose();
                    scriptDumper = new ScriptDumper(openFolderDialog.Folder);
                    Logger.Info("载入DLL完成");
                }
            } else {
                MessageBox.Show(this, "未加载Data文件");
            }
        }

        private void 关闭文件ToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearForm();
            Logger.Info("文件已关闭");
        }
    }

    public class GUILogger : ILogger {
        public Action<string> LogEvent;
        public void Log(LoggerEvent loggerEvent, string message) {
            LogEvent($"[{loggerEvent}] {message}");
        }
    }

    public class GUIProgress : IProgress {
        public Action<int> reportEvent;
        public void Report(int value) {
            reportEvent(value);
        }
    }
}
