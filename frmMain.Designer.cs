namespace ScreenShotter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMain = new System.Windows.Forms.Button();
            this.btnChooseOutputPath = new System.Windows.Forms.Button();
            this.edtName = new System.Windows.Forms.TextBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFileFormat = new System.Windows.Forms.ComboBox();
            this.chkSnipMouseScreen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(4, 5);
            this.btnMain.Margin = new System.Windows.Forms.Padding(5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(258, 92);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Screenshot";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnChooseOutputPath
            // 
            this.btnChooseOutputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnChooseOutputPath.FlatAppearance.BorderSize = 0;
            this.btnChooseOutputPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseOutputPath.Location = new System.Drawing.Point(4, 101);
            this.btnChooseOutputPath.Margin = new System.Windows.Forms.Padding(5);
            this.btnChooseOutputPath.Name = "btnChooseOutputPath";
            this.btnChooseOutputPath.Size = new System.Drawing.Size(258, 33);
            this.btnChooseOutputPath.TabIndex = 1;
            this.btnChooseOutputPath.Text = "File Out";
            this.btnChooseOutputPath.UseVisualStyleBackColor = false;
            this.btnChooseOutputPath.Click += new System.EventHandler(this.btnChooseOutputPath_Click);
            // 
            // edtName
            // 
            this.edtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.edtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtName.ForeColor = System.Drawing.Color.Transparent;
            this.edtName.Location = new System.Drawing.Point(85, 138);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(177, 30);
            this.edtName.TabIndex = 2;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(4, 252);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(62, 23);
            this.lblDebug.TabIndex = 3;
            this.lblDebug.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Format:";
            // 
            // cmbFileFormat
            // 
            this.cmbFileFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cmbFileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFileFormat.ForeColor = System.Drawing.Color.Transparent;
            this.cmbFileFormat.FormattingEnabled = true;
            this.cmbFileFormat.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "JPEG"});
            this.cmbFileFormat.Location = new System.Drawing.Point(85, 177);
            this.cmbFileFormat.Name = "cmbFileFormat";
            this.cmbFileFormat.Size = new System.Drawing.Size(177, 31);
            this.cmbFileFormat.TabIndex = 6;
            // 
            // chkSnipMouseScreen
            // 
            this.chkSnipMouseScreen.AutoSize = true;
            this.chkSnipMouseScreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSnipMouseScreen.Location = new System.Drawing.Point(4, 211);
            this.chkSnipMouseScreen.Name = "chkSnipMouseScreen";
            this.chkSnipMouseScreen.Size = new System.Drawing.Size(191, 27);
            this.chkSnipMouseScreen.TabIndex = 7;
            this.chkSnipMouseScreen.Text = "Snip Mouse Screen";
            this.chkSnipMouseScreen.UseVisualStyleBackColor = true;
            this.chkSnipMouseScreen.CheckedChanged += new System.EventHandler(this.chkSnipMouseScreen_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(266, 245);
            this.Controls.Add(this.chkSnipMouseScreen);
            this.Controls.Add(this.cmbFileFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.btnChooseOutputPath);
            this.Controls.Add(this.btnMain);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Shot - Manuel Nunes™";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMain;
        private Button btnChooseOutputPath;
        private TextBox edtName;
        private Label lblDebug;
        private Label label1;
        private Label label2;
        private ComboBox cmbFileFormat;
        private CheckBox chkSnipMouseScreen;
    }
}