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
            openFileDialog.Multiselect = false;
        }

        public AssetsManager manager;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private OpenFolderDialog openFolderDialog = new OpenFolderDialog();


        // 加载和列表刷新
        private void 加载文件ToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.Title = "打开文件";
            openFileDialog.DefaultExt = "*.*|所有文件";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                Enabled = false;
                ClearForm();
                ThreadPool.QueueUserWorkItem(delegate {
                    manager.LoadFiles(openFileDialog.FileName);
                    BeginInvoke(new Action(delegate { AfterLoad(); }));
                });
            }
        }

        private void 加载文件夹ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFolderDialog.ShowDialog(this) == DialogResult.OK) {
                Enabled = false;
                ClearForm();
                ThreadPool.QueueUserWorkItem(delegate {
                    manager.LoadFolder(openFolderDialog.Folder);
                    BeginInvoke(new Action(delegate { AfterLoad(); }));
                });
            }
        }

        private void AfterLoad() {
            if (manager.assetsFileList.Count > 0) {
                foreach (var assetFile in manager.assetsFileList) {
                    FileView_Selector.Items.Add(assetFile.fileName);
                }
                Text = "Version: " + manager.assetsFileList[0].unityVersion;
            } else {
                Logger.Info("No File Load");
            }
            Enabled = true;
        }

        private void ClearForm() {
            FileView_Selector.Items.Clear();
            ExternalList.Items.Clear();
            AssetObjList.Items.Clear();
            DumpText.Text = "";
            FileInfoText.Text = "";
            Text = "MainForm";
        }

        // 列表选中具体某一项
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

        private void ShowInfoForObj(AssetObject assetObject) {
            StringBuilder builder = new StringBuilder();
            builder.Append("FileName: ").Append(assetObject.assetsFile.fileName).AppendLine();
            builder.Append("PathID: ").Append(assetObject.m_PathID).AppendLine();
            builder.Append("Type: ").Append(assetObject.type).AppendLine();
            builder.Append("ByteStart: ").AppendFormat("0x{0:X}", assetObject.reader.byteStart).AppendLine();
            builder.Append("ByteSize: ").AppendFormat("0x{0:X}", assetObject.reader.byteSize).AppendLine();
            builder.Append("ByteSize: ").AppendFormat("0x{0:X}",
                assetObject.reader.byteStart + assetObject.reader.byteSize - 1).AppendLine();
            FileInfoText.Text = builder.ToString();
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
