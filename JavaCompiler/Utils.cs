using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CompileJava
{
   public static class Utils
   {
      public static string ExecuteCommandSync(object command)
      {
         string result = "";
         try
         {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c" + command)
            {
               RedirectStandardOutput = true,
               UseShellExecute = false,
               CreateNoWindow = true,
            };
            Process process = new Process()
            {
               StartInfo = processStartInfo,
            };
            process.Start();

            result = process.StandardOutput.ReadToEnd();
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         return result.Replace("\n", "");
      }

      public static void GenerateBashFile(string javaClassName, string directoryPath)
      {
         string filePath = Path.Combine(directoryPath, "compile.sh");
         if (File.Exists(filePath)) { File.Delete(filePath); }

         string bashCommand = $"cd /data\njavac {javaClassName}.java\njava {javaClassName} \"$@\"";
         File.WriteAllText(filePath, bashCommand);
      }

      public static string GetClassName(string javaCode)
      {
         int startIndex = javaCode.IndexOf("class ") + 6;
         if (startIndex < 6) { return ""; }

         int length = javaCode.IndexOf("{") - startIndex;
         if (length < 0) { return ""; }

         return javaCode.Substring(startIndex, length).Trim();
      }

      public static void SaveJavaCode(string filePath, string code)
      {
         if (File.Exists(filePath)) { File.Delete(filePath); }
         File.WriteAllText(filePath, code);
      }

      public class IniFile
      {
         string Section;
         string Path;
         string EXE = Assembly.GetExecutingAssembly().GetName().Name;

         [DllImport("kernel32", CharSet = CharSet.Unicode)]
         static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

         [DllImport("kernel32", CharSet = CharSet.Unicode)]
         static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

         public IniFile(string IniPath = null, string IniSection = null)
         {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            Section = IniSection ?? EXE;
         }

         public string Read(string Key)
         {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
         }

         public void Write(string Key, string Value)
         {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
         }

         public void DeleteKey(string Key)
         {
            Write(Key, null);
         }

         public void DeleteSection(string Section = null)
         {
            Write(null, null);
         }

         public bool KeyExists(string Key)
         {
            return Read(Key).Length > 0;
         }
      }
   }
}
