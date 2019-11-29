using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetStudio;
using System.Windows.Forms;

namespace SceneViewer {
    static class HierarchiesBuilder {
        public static TreeNode BuildHierarchiesTree(this SerializedFile file) {

            List<GameObject> gameObjects = new List<GameObject>();
            foreach (var obj in file.Objects)
                if (obj.Value is GameObject gameObject)
                    gameObjects.Add(gameObject);

            List<GameObject> roots = new List<GameObject>();
            foreach (var obj in gameObjects) {
                if (obj.m_Transform.m_Father.m_PathID == 0 ||
                    !obj.m_Transform.m_Father.TryGet(out Transform result)) {
                    roots.Add(obj);
                }
            }

            TreeNode node = new TreeNode();
            node.Tag = file;
            node.Text = file.fileName;

            foreach (var gameObject in roots)
                node.Nodes.Add(BuildTreeNode(gameObject));

            return node;
        }

        private static TreeNode BuildTreeNode(GameObject gameObject) {
            TreeNode node = new TreeNode();
            node.Text = gameObject.m_Name;
            node.Tag = gameObject;
            foreach (var child in gameObject.m_Transform.m_Children) {
                if (child.TryGet(out var transform) && transform.m_GameObject.TryGet(out var childObj))
                    node.Nodes.Add(BuildTreeNode(childObj));
            }
            return node;
        }

        public static TreeNode[] BuildComponentsList(this GameObject gameObject) {
            List<TreeNode> items = new List<TreeNode>();

            foreach (var comPPtr in gameObject.m_Components) {
                if (comPPtr.TryGet(out Component component)) {
                    if (component is MonoBehaviour monoBehaviour) {
                        if (monoBehaviour.m_Script.TryGet(out MonoScript script)) {
                            items.Add(new TreeNode() {
                                Text = script.m_ClassName + " (MonoBehaviour)",
                                Tag = component
                            });
                            continue;
                        }
                    }

                    items.Add(new TreeNode() {
                        Text = component.type.ToString(),
                        Tag = component
                    });
                }
            }

            return items.ToArray();
        }
    }
}
