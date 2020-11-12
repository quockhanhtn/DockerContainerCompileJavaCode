namespace CompileJava
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.mainTbLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.txtContainerName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnStartContainer = new System.Windows.Forms.Button();
         this.txtDataPath = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnBrowseDataPath = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.txtJavaCode = new System.Windows.Forms.TextBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.txtParameter = new System.Windows.Forms.TextBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.btnCompile = new System.Windows.Forms.Button();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.txtResult = new System.Windows.Forms.TextBox();
         this.mainTbLayoutPnl.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.groupBox5.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainTbLayoutPnl
         // 
         this.mainTbLayoutPnl.ColumnCount = 1;
         this.mainTbLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.mainTbLayoutPnl.Controls.Add(this.groupBox1, 0, 0);
         this.mainTbLayoutPnl.Controls.Add(this.groupBox2, 0, 1);
         this.mainTbLayoutPnl.Controls.Add(this.groupBox3, 0, 2);
         this.mainTbLayoutPnl.Controls.Add(this.groupBox4, 0, 3);
         this.mainTbLayoutPnl.Controls.Add(this.groupBox5, 0, 4);
         this.mainTbLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainTbLayoutPnl.Location = new System.Drawing.Point(0, 0);
         this.mainTbLayoutPnl.Name = "mainTbLayoutPnl";
         this.mainTbLayoutPnl.RowCount = 5;
         this.mainTbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
         this.mainTbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.mainTbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.mainTbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
         this.mainTbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
         this.mainTbLayoutPnl.Size = new System.Drawing.Size(682, 703);
         this.mainTbLayoutPnl.TabIndex = 0;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.tableLayoutPanel2);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox1.Location = new System.Drawing.Point(10, 10);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(662, 100);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Docker container";
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 3;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel2.Controls.Add(this.txtContainerName, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnStartContainer, 2, 0);
         this.tableLayoutPanel2.Controls.Add(this.txtDataPath, 1, 1);
         this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.btnBrowseDataPath, 2, 1);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 2;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 79);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // txtContainerName
         // 
         this.txtContainerName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtContainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtContainerName.Location = new System.Drawing.Point(153, 5);
         this.txtContainerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
         this.txtContainerName.Name = "txtContainerName";
         this.txtContainerName.Size = new System.Drawing.Size(400, 27);
         this.txtContainerName.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(144, 39);
         this.label1.TabIndex = 1;
         this.label1.Text = "Container name:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // btnStartContainer
         // 
         this.btnStartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnStartContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnStartContainer.Location = new System.Drawing.Point(559, 5);
         this.btnStartContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
         this.btnStartContainer.Name = "btnStartContainer";
         this.btnStartContainer.Size = new System.Drawing.Size(94, 28);
         this.btnStartContainer.TabIndex = 2;
         this.btnStartContainer.Text = "Start";
         this.btnStartContainer.UseVisualStyleBackColor = true;
         this.btnStartContainer.Click += new System.EventHandler(this.btnStartContainer_Click);
         // 
         // txtDataPath
         // 
         this.txtDataPath.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDataPath.Location = new System.Drawing.Point(153, 44);
         this.txtDataPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
         this.txtDataPath.Name = "txtDataPath";
         this.txtDataPath.Size = new System.Drawing.Size(400, 27);
         this.txtDataPath.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label2.Location = new System.Drawing.Point(3, 39);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(144, 40);
         this.label2.TabIndex = 1;
         this.label2.Text = "Data path:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // btnBrowseDataPath
         // 
         this.btnBrowseDataPath.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnBrowseDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBrowseDataPath.Location = new System.Drawing.Point(559, 44);
         this.btnBrowseDataPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
         this.btnBrowseDataPath.Name = "btnBrowseDataPath";
         this.btnBrowseDataPath.Size = new System.Drawing.Size(94, 29);
         this.btnBrowseDataPath.TabIndex = 2;
         this.btnBrowseDataPath.Text = "Browse";
         this.btnBrowseDataPath.UseVisualStyleBackColor = true;
         this.btnBrowseDataPath.Click += new System.EventHandler(this.btnBrowseDataPath_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.txtJavaCode);
         this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox2.Location = new System.Drawing.Point(10, 130);
         this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
         this.groupBox2.Size = new System.Drawing.Size(662, 280);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Java code";
         // 
         // txtJavaCode
         // 
         this.txtJavaCode.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtJavaCode.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtJavaCode.Location = new System.Drawing.Point(20, 25);
         this.txtJavaCode.Multiline = true;
         this.txtJavaCode.Name = "txtJavaCode";
         this.txtJavaCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtJavaCode.Size = new System.Drawing.Size(632, 245);
         this.txtJavaCode.TabIndex = 0;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.txtParameter);
         this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox3.Location = new System.Drawing.Point(10, 430);
         this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
         this.groupBox3.Size = new System.Drawing.Size(662, 60);
         this.groupBox3.TabIndex = 2;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Parameter";
         // 
         // txtParameter
         // 
         this.txtParameter.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtParameter.Location = new System.Drawing.Point(20, 25);
         this.txtParameter.Name = "txtParameter";
         this.txtParameter.Size = new System.Drawing.Size(632, 24);
         this.txtParameter.TabIndex = 0;
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.tableLayoutPanel3);
         this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox4.Location = new System.Drawing.Point(10, 510);
         this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 9);
         this.groupBox4.Size = new System.Drawing.Size(662, 63);
         this.groupBox4.TabIndex = 3;
         this.groupBox4.TabStop = false;
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
         this.tableLayoutPanel3.Controls.Add(this.btnCompile, 1, 0);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 15);
         this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(656, 39);
         this.tableLayoutPanel3.TabIndex = 0;
         // 
         // btnCompile
         // 
         this.btnCompile.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCompile.Location = new System.Drawing.Point(509, 3);
         this.btnCompile.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
         this.btnCompile.Name = "btnCompile";
         this.btnCompile.Size = new System.Drawing.Size(134, 33);
         this.btnCompile.TabIndex = 3;
         this.btnCompile.Text = "Compile";
         this.btnCompile.UseVisualStyleBackColor = true;
         this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
         // 
         // groupBox5
         // 
         this.groupBox5.Controls.Add(this.txtResult);
         this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox5.Location = new System.Drawing.Point(10, 593);
         this.groupBox5.Margin = new System.Windows.Forms.Padding(10);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
         this.groupBox5.Size = new System.Drawing.Size(662, 100);
         this.groupBox5.TabIndex = 4;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Result";
         // 
         // txtResult
         // 
         this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtResult.Location = new System.Drawing.Point(20, 25);
         this.txtResult.Multiline = true;
         this.txtResult.Name = "txtResult";
         this.txtResult.ReadOnly = true;
         this.txtResult.Size = new System.Drawing.Size(632, 65);
         this.txtResult.TabIndex = 0;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(682, 703);
         this.Controls.Add(this.mainTbLayoutPnl);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Java compiler - Khanh Lam Quoc 18110304";
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.mainTbLayoutPnl.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.groupBox5.ResumeLayout(false);
         this.groupBox5.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel mainTbLayoutPnl;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.TextBox txtContainerName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox txtParameter;
      private System.Windows.Forms.TextBox txtJavaCode;
      private System.Windows.Forms.Button btnStartContainer;
      private System.Windows.Forms.Button btnCompile;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.TextBox txtResult;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.TextBox txtDataPath;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnBrowseDataPath;
   }
}

