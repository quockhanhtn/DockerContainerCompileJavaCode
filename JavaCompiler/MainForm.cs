using System;
using System.IO;
using System.Windows.Forms;
using static CompileJava.Utils;

namespace CompileJava
{
   public partial class MainForm : Form
   {
      private IniFile iniFileConfig;

      public string ContainerName
      {
         get => txtContainerName.Text;
         set => txtContainerName.Text = value;
      }
      public string DataPath
      {
         get => txtDataPath.Text;
         set => txtDataPath.Text = value;
      }

      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
         filePath = filePath.Substring(0, filePath.LastIndexOf("\\")) + "\\Config.ini";
         iniFileConfig = new IniFile(filePath, "Setting");

         ContainerName = iniFileConfig.Read(nameof(ContainerName));
         DataPath = iniFileConfig.Read(nameof(DataPath));
      }

      private void btnStartContainer_Click(object sender, EventArgs e)
      {
         mainTbLayoutPnl.Enabled = false;
         if (btnStartContainer.Text == "Start")
         {
            btnStartContainer.Text = "Stop";
            txtContainerName.ReadOnly = true;

            txtResult.Text = Utils.ExecuteCommandSync("docker start " + ContainerName).Replace("\n", "");
         }
         else
         {
            btnStartContainer.Text = "Start";
            txtContainerName.ReadOnly = false;

            txtResult.Text = Utils.ExecuteCommandSync("docker stop " + ContainerName).Replace("\n", "");
         }

         iniFileConfig.Write(nameof(ContainerName), ContainerName);
         mainTbLayoutPnl.Enabled = true;
      }

      private void btnCompile_Click(object sender, EventArgs e)
      {
         mainTbLayoutPnl.Enabled = false;
         string javaClassName = Utils.GetClassName(txtJavaCode.Text);

         if (!Directory.Exists(DataPath))
         {
            MessageBox.Show($"Can not find data directory '{DataPath}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnBrowseDataPath.PerformClick();
         }
         else
         {
            if (string.IsNullOrEmpty(javaClassName))
            {
               MessageBox.Show("Can not find class name in Java code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtJavaCode.Focus();
            }
            else
            {
               Utils.SaveJavaCode(Path.Combine(DataPath, javaClassName + ".java"), txtJavaCode.Text);
               Utils.GenerateBashFile(javaClassName, DataPath);

               string command = $"docker exec {ContainerName} bash /data/compile.sh {@txtParameter.Text}";
               txtResult.Text = Utils.ExecuteCommandSync(command);
            }
         }

         iniFileConfig.Write(nameof(ContainerName), ContainerName);
         iniFileConfig.Write(nameof(DataPath), DataPath);

         mainTbLayoutPnl.Enabled = true;
      }

      private void btnBrowseDataPath_Click(object sender, EventArgs e)
      {
         using (var dialog = new FolderBrowserDialog())
         {
            dialog.SelectedPath = DataPath;

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
               DataPath = dialog.SelectedPath;
            }
         }
      }
   }
}
