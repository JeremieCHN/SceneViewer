using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AssetStudio;
using AssetObject = AssetStudio.Object;

namespace SceneViewer {
    static class DumpHelper {
        public static string DumpFileInfo(this AssetObject assetObject) {
            StringBuilder builder = new StringBuilder();
            builder.Append("FileName: ").Append(assetObject.assetsFile.fileName).AppendLine();
            builder.Append("PathID: ").Append(assetObject.m_PathID).AppendLine();
            builder.Append("Type: ").Append(assetObject.type).AppendLine();
            builder.Append("ByteStart: ").AppendFormat("0x{0:X}", assetObject.reader.byteStart).AppendLine();
            builder.Append("ByteSize: ").AppendFormat("0x{0:X}", assetObject.reader.byteSize).AppendLine();
            builder.Append("ByteSize: ").AppendFormat("0x{0:X}",
                assetObject.reader.byteStart + assetObject.reader.byteSize - 1).AppendLine();
            return builder.ToString();
        }

        public static string DumpObjInfo(this AssetObject assetObject) {
            // TODO 其他类型不会做啊
            StringBuilder builder = new StringBuilder();
            switch (assetObject) {
                case GameObject gameObject:
                    return gameObject.DumpObjInfo();
                case MonoScript monoScript:
                    return monoScript.DumpObjInfo();
                default:
                    builder.Append(assetObject.ToString());
                    break;
            }
            return builder.ToString();
        }

        private static string DumpObjInfo(this GameObject gameObject) {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Array m_Component");
            builder.AppendLine("\tint size = " + gameObject.m_Components.Length);
            for (int i = 0; i < gameObject.m_Components.Length; i++) {
                builder.AppendLine($"\t\t[{i}]");
                builder.AppendLine($"\t\tm_FileID = {gameObject.m_Components[i].m_FileID}");
                builder.AppendLine($"\t\tm_PathID = {gameObject.m_Components[i].m_PathID}");
            }

            builder.AppendLine("m_Name: " + gameObject.m_Name);
            return builder.ToString();
        }

        private static string DumpObjInfo(this MonoScript monoScript) {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Type: MonoScript");
            builder.AppendLine("AssemblyFile: " + monoScript.m_AssemblyName);
            builder.AppendLine("NameSpace: " + monoScript.m_Namespace);
            builder.AppendLine("Class: " + monoScript.m_ClassName);
            return builder.ToString();
        }
    }
}
