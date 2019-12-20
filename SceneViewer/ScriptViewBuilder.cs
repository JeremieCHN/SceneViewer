using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetStudio;

namespace SceneViewer {
    class ScriptViewBuilder {
        public static TreeNode[] BuildScriptTree(AssetsManager manager) {
            Logger.Info("收集MonoScript对象");
            Progress.Reset();

            List<MonoScript> monoScripts = new List<MonoScript>();
            for (int i = 0; i < manager.assetsFileList.Count; i++) {
                var file = manager.assetsFileList[i];
                foreach (var obj in file.Objects.Values) {
                    if (obj is MonoScript script)
                        monoScripts.Add(script);
                }
                Progress.Report(i, manager.assetsFileList.Count);
            }

            // 整理DLL文件
            Logger.Info("按照DLL分组");
            Progress.Reset();

            Dictionary<string, List<MonoScript>> DLL = new Dictionary<string, List<MonoScript>>();
            for (int i = 0; i < monoScripts.Count; i++) {
                var script = monoScripts[i];
                if (!DLL.ContainsKey(script.m_AssemblyName))
                    DLL[script.m_AssemblyName] = new List<MonoScript>();
                DLL[script.m_AssemblyName].Add(script);
                Progress.Report(i, monoScripts.Count);
            }

            // 逐个DLL构建节点
            Logger.Info("按照DLL构建节点");
            List<TreeNode> DLLNodes = new List<TreeNode>();
            int j = 0;
            foreach (var entry in DLL) {
                DLLNodes.Add(BuildDLLNode(entry.Key, entry.Value));
                Progress.Report(j++, DLL.Count);
            }

            return DLLNodes.ToArray();
        }

        private static TreeNode BuildDLLNode(string DLLName, List<MonoScript> scripts) {
            // 按照命名空间整理
            Dictionary<string, List<MonoScript>> NameSpaces = new Dictionary<string, List<MonoScript>>();

            foreach (var script in scripts) {
                if (!NameSpaces.ContainsKey(script.m_Namespace))
                    NameSpaces[script.m_Namespace] = new List<MonoScript>();
                NameSpaces[script.m_Namespace].Add(script);
            }

            TreeNode root = new TreeNode(DLLName);
            foreach (var entry in NameSpaces) {
                TreeNode node = new TreeNode();
                if (string.IsNullOrEmpty(entry.Key))
                    node.Text = "[Default NameSpace]";
                else
                    node.Text = entry.Key;

                foreach (var script in entry.Value) {
                    node.Nodes.Add(new TreeNode {
                        Text = script.m_ClassName,
                        Tag = script
                    });
                }
                root.Nodes.Add(node);
            }

            return root;
        }
    }
}
