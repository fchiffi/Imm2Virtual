namespace Imm2Virtual
{
    partial class I2VFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I2VFrm));
            I2VTab = new TabControl();
            ConversionPanel = new TabPage();
            ConversionGB = new GroupBox();
            KOCImg = new PictureBox();
            OKCImg = new PictureBox();
            KOMImg = new PictureBox();
            OKMImg = new PictureBox();
            MntLbl = new Label();
            ConvertLbl = new Label();
            KODImg = new PictureBox();
            OKDImg = new PictureBox();
            KOSImg = new PictureBox();
            OKSImg = new PictureBox();
            ConvertBtn = new Button();
            DestinationImagePathTxt = new TextBox();
            SelectDestinationImagePathBtn = new Button();
            SourceImagePathTxt = new TextBox();
            SelectSourceImagePathBtn = new Button();
            LogPanel = new TabPage();
            logTxt = new TextBox();
            ConfigurationPanel = new TabPage();
            KOVBOXImg = new PictureBox();
            OKVBOXImg = new PictureBox();
            KOAIMImg = new PictureBox();
            OKAIMImg = new PictureBox();
            VBOXPathTxt = new TextBox();
            AIMPathTxt = new TextBox();
            SelectVBOXPathBtn = new Button();
            SelectAIMPathBtn = new Button();
            EAgb = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            AIMlbl = new Label();
            VVlbl = new Label();
            SelectSourceImageFileDialog = new OpenFileDialog();
            MounterBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            SelectDestinationImageFileDialog = new SaveFileDialog();
            SelectAIMFileDialog = new OpenFileDialog();
            SelectVBOXFileDialog = new OpenFileDialog();
            I2VTab.SuspendLayout();
            ConversionPanel.SuspendLayout();
            ConversionGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KOCImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKCImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KOMImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKMImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KODImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKDImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KOSImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKSImg).BeginInit();
            LogPanel.SuspendLayout();
            ConfigurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KOVBOXImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKVBOXImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KOAIMImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKAIMImg).BeginInit();
            EAgb.SuspendLayout();
            SuspendLayout();
            // 
            // I2VTab
            // 
            I2VTab.Controls.Add(ConversionPanel);
            I2VTab.Controls.Add(LogPanel);
            I2VTab.Controls.Add(ConfigurationPanel);
            I2VTab.Location = new Point(2, 1);
            I2VTab.Name = "I2VTab";
            I2VTab.SelectedIndex = 0;
            I2VTab.Size = new Size(762, 330);
            I2VTab.TabIndex = 1;
            // 
            // ConversionPanel
            // 
            ConversionPanel.Controls.Add(ConversionGB);
            ConversionPanel.Controls.Add(KODImg);
            ConversionPanel.Controls.Add(OKDImg);
            ConversionPanel.Controls.Add(KOSImg);
            ConversionPanel.Controls.Add(OKSImg);
            ConversionPanel.Controls.Add(ConvertBtn);
            ConversionPanel.Controls.Add(DestinationImagePathTxt);
            ConversionPanel.Controls.Add(SelectDestinationImagePathBtn);
            ConversionPanel.Controls.Add(SourceImagePathTxt);
            ConversionPanel.Controls.Add(SelectSourceImagePathBtn);
            ConversionPanel.Location = new Point(4, 24);
            ConversionPanel.Name = "ConversionPanel";
            ConversionPanel.Padding = new Padding(3);
            ConversionPanel.Size = new Size(754, 302);
            ConversionPanel.TabIndex = 0;
            ConversionPanel.Text = "Image conversion";
            ConversionPanel.UseVisualStyleBackColor = true;
            // 
            // ConversionGB
            // 
            ConversionGB.Controls.Add(KOCImg);
            ConversionGB.Controls.Add(OKCImg);
            ConversionGB.Controls.Add(KOMImg);
            ConversionGB.Controls.Add(OKMImg);
            ConversionGB.Controls.Add(MntLbl);
            ConversionGB.Controls.Add(ConvertLbl);
            ConversionGB.Location = new Point(169, 146);
            ConversionGB.Name = "ConversionGB";
            ConversionGB.Size = new Size(574, 141);
            ConversionGB.TabIndex = 18;
            ConversionGB.TabStop = false;
            ConversionGB.Text = "Conversion";
            // 
            // KOCImg
            // 
            KOCImg.Image = (Image)resources.GetObject("KOCImg.Image");
            KOCImg.Location = new Point(518, 75);
            KOCImg.Name = "KOCImg";
            KOCImg.Size = new Size(50, 50);
            KOCImg.SizeMode = PictureBoxSizeMode.Zoom;
            KOCImg.TabIndex = 19;
            KOCImg.TabStop = false;
            // 
            // OKCImg
            // 
            OKCImg.Image = (Image)resources.GetObject("OKCImg.Image");
            OKCImg.Location = new Point(518, 75);
            OKCImg.Name = "OKCImg";
            OKCImg.Size = new Size(50, 50);
            OKCImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKCImg.TabIndex = 20;
            OKCImg.TabStop = false;
            // 
            // KOMImg
            // 
            KOMImg.Image = (Image)resources.GetObject("KOMImg.Image");
            KOMImg.Location = new Point(518, 19);
            KOMImg.Name = "KOMImg";
            KOMImg.Size = new Size(50, 50);
            KOMImg.SizeMode = PictureBoxSizeMode.Zoom;
            KOMImg.TabIndex = 19;
            KOMImg.TabStop = false;
            // 
            // OKMImg
            // 
            OKMImg.Image = (Image)resources.GetObject("OKMImg.Image");
            OKMImg.Location = new Point(518, 19);
            OKMImg.Name = "OKMImg";
            OKMImg.Size = new Size(50, 50);
            OKMImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKMImg.TabIndex = 18;
            OKMImg.TabStop = false;
            // 
            // MntLbl
            // 
            MntLbl.AutoSize = true;
            MntLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MntLbl.Location = new Point(6, 32);
            MntLbl.Name = "MntLbl";
            MntLbl.Size = new Size(177, 37);
            MntLbl.TabIndex = 15;
            MntLbl.Text = "Mount image";
            // 
            // ConvertLbl
            // 
            ConvertLbl.AutoSize = true;
            ConvertLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertLbl.Location = new Point(6, 88);
            ConvertLbl.Name = "ConvertLbl";
            ConvertLbl.Size = new Size(191, 37);
            ConvertLbl.TabIndex = 16;
            ConvertLbl.Text = "Convert image";
            // 
            // KODImg
            // 
            KODImg.Image = (Image)resources.GetObject("KODImg.Image");
            KODImg.Location = new Point(693, 72);
            KODImg.Name = "KODImg";
            KODImg.Size = new Size(50, 50);
            KODImg.SizeMode = PictureBoxSizeMode.Zoom;
            KODImg.TabIndex = 14;
            KODImg.TabStop = false;
            // 
            // OKDImg
            // 
            OKDImg.Image = (Image)resources.GetObject("OKDImg.Image");
            OKDImg.Location = new Point(693, 72);
            OKDImg.Name = "OKDImg";
            OKDImg.Size = new Size(50, 50);
            OKDImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKDImg.TabIndex = 13;
            OKDImg.TabStop = false;
            // 
            // KOSImg
            // 
            KOSImg.Image = (Image)resources.GetObject("KOSImg.Image");
            KOSImg.Location = new Point(693, 6);
            KOSImg.Name = "KOSImg";
            KOSImg.Size = new Size(50, 50);
            KOSImg.SizeMode = PictureBoxSizeMode.Zoom;
            KOSImg.TabIndex = 12;
            KOSImg.TabStop = false;
            // 
            // OKSImg
            // 
            OKSImg.Image = (Image)resources.GetObject("OKSImg.Image");
            OKSImg.Location = new Point(693, 6);
            OKSImg.Name = "OKSImg";
            OKSImg.Size = new Size(50, 50);
            OKSImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKSImg.TabIndex = 11;
            OKSImg.TabStop = false;
            // 
            // ConvertBtn
            // 
            ConvertBtn.Enabled = false;
            ConvertBtn.Location = new Point(12, 146);
            ConvertBtn.Name = "ConvertBtn";
            ConvertBtn.Size = new Size(151, 38);
            ConvertBtn.TabIndex = 10;
            ConvertBtn.Text = "Convert";
            ConvertBtn.UseVisualStyleBackColor = true;
            ConvertBtn.Click += ConvertBtn_Click;
            // 
            // DestinationImagePathTxt
            // 
            DestinationImagePathTxt.Location = new Point(169, 90);
            DestinationImagePathTxt.Name = "DestinationImagePathTxt";
            DestinationImagePathTxt.ReadOnly = true;
            DestinationImagePathTxt.Size = new Size(518, 23);
            DestinationImagePathTxt.TabIndex = 9;
            // 
            // SelectDestinationImagePathBtn
            // 
            SelectDestinationImagePathBtn.Enabled = false;
            SelectDestinationImagePathBtn.Location = new Point(12, 81);
            SelectDestinationImagePathBtn.Name = "SelectDestinationImagePathBtn";
            SelectDestinationImagePathBtn.Size = new Size(151, 38);
            SelectDestinationImagePathBtn.TabIndex = 8;
            SelectDestinationImagePathBtn.Text = "Select destination image path";
            SelectDestinationImagePathBtn.UseVisualStyleBackColor = true;
            SelectDestinationImagePathBtn.Click += SelectDestinationImagePathBtn_Click;
            // 
            // SourceImagePathTxt
            // 
            SourceImagePathTxt.Location = new Point(169, 23);
            SourceImagePathTxt.Name = "SourceImagePathTxt";
            SourceImagePathTxt.ReadOnly = true;
            SourceImagePathTxt.Size = new Size(518, 23);
            SourceImagePathTxt.TabIndex = 2;
            // 
            // SelectSourceImagePathBtn
            // 
            SelectSourceImagePathBtn.Enabled = false;
            SelectSourceImagePathBtn.Location = new Point(12, 14);
            SelectSourceImagePathBtn.Name = "SelectSourceImagePathBtn";
            SelectSourceImagePathBtn.Size = new Size(151, 38);
            SelectSourceImagePathBtn.TabIndex = 1;
            SelectSourceImagePathBtn.Text = "Select source image path";
            SelectSourceImagePathBtn.UseVisualStyleBackColor = true;
            SelectSourceImagePathBtn.Click += SelectSourceImagePathButton_Click;
            // 
            // LogPanel
            // 
            LogPanel.Controls.Add(logTxt);
            LogPanel.Location = new Point(4, 24);
            LogPanel.Name = "LogPanel";
            LogPanel.Padding = new Padding(3);
            LogPanel.Size = new Size(754, 302);
            LogPanel.TabIndex = 1;
            LogPanel.Text = "Log";
            LogPanel.UseVisualStyleBackColor = true;
            // 
            // logTxt
            // 
            logTxt.Location = new Point(6, 6);
            logTxt.Multiline = true;
            logTxt.Name = "logTxt";
            logTxt.ReadOnly = true;
            logTxt.ScrollBars = ScrollBars.Both;
            logTxt.Size = new Size(742, 290);
            logTxt.TabIndex = 0;
            // 
            // ConfigurationPanel
            // 
            ConfigurationPanel.Controls.Add(KOVBOXImg);
            ConfigurationPanel.Controls.Add(OKVBOXImg);
            ConfigurationPanel.Controls.Add(KOAIMImg);
            ConfigurationPanel.Controls.Add(OKAIMImg);
            ConfigurationPanel.Controls.Add(VBOXPathTxt);
            ConfigurationPanel.Controls.Add(AIMPathTxt);
            ConfigurationPanel.Controls.Add(SelectVBOXPathBtn);
            ConfigurationPanel.Controls.Add(SelectAIMPathBtn);
            ConfigurationPanel.Controls.Add(EAgb);
            ConfigurationPanel.Location = new Point(4, 24);
            ConfigurationPanel.Name = "ConfigurationPanel";
            ConfigurationPanel.Padding = new Padding(3);
            ConfigurationPanel.Size = new Size(754, 302);
            ConfigurationPanel.TabIndex = 2;
            ConfigurationPanel.Text = "Configuration";
            ConfigurationPanel.UseVisualStyleBackColor = true;
            // 
            // KOVBOXImg
            // 
            KOVBOXImg.Image = (Image)resources.GetObject("KOVBOXImg.Image");
            KOVBOXImg.Location = new Point(698, 71);
            KOVBOXImg.Name = "KOVBOXImg";
            KOVBOXImg.Size = new Size(50, 50);
            KOVBOXImg.SizeMode = PictureBoxSizeMode.Zoom;
            KOVBOXImg.TabIndex = 8;
            KOVBOXImg.TabStop = false;
            // 
            // OKVBOXImg
            // 
            OKVBOXImg.Image = (Image)resources.GetObject("OKVBOXImg.Image");
            OKVBOXImg.Location = new Point(698, 71);
            OKVBOXImg.Name = "OKVBOXImg";
            OKVBOXImg.Size = new Size(50, 50);
            OKVBOXImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKVBOXImg.TabIndex = 7;
            OKVBOXImg.TabStop = false;
            // 
            // KOAIMImg
            // 
            KOAIMImg.Image = (Image)resources.GetObject("KOAIMImg.Image");
            KOAIMImg.Location = new Point(698, 6);
            KOAIMImg.Name = "KOAIMImg";
            KOAIMImg.Size = new Size(50, 50);
            KOAIMImg.SizeMode = PictureBoxSizeMode.Zoom;
            KOAIMImg.TabIndex = 6;
            KOAIMImg.TabStop = false;
            // 
            // OKAIMImg
            // 
            OKAIMImg.Image = (Image)resources.GetObject("OKAIMImg.Image");
            OKAIMImg.Location = new Point(698, 6);
            OKAIMImg.Name = "OKAIMImg";
            OKAIMImg.Size = new Size(50, 50);
            OKAIMImg.SizeMode = PictureBoxSizeMode.Zoom;
            OKAIMImg.TabIndex = 5;
            OKAIMImg.TabStop = false;
            // 
            // VBOXPathTxt
            // 
            VBOXPathTxt.Location = new Point(163, 83);
            VBOXPathTxt.Name = "VBOXPathTxt";
            VBOXPathTxt.ReadOnly = true;
            VBOXPathTxt.Size = new Size(529, 23);
            VBOXPathTxt.TabIndex = 4;
            // 
            // AIMPathTxt
            // 
            AIMPathTxt.Location = new Point(163, 23);
            AIMPathTxt.Name = "AIMPathTxt";
            AIMPathTxt.ReadOnly = true;
            AIMPathTxt.Size = new Size(529, 23);
            AIMPathTxt.TabIndex = 3;
            // 
            // SelectVBOXPathBtn
            // 
            SelectVBOXPathBtn.Location = new Point(6, 74);
            SelectVBOXPathBtn.Name = "SelectVBOXPathBtn";
            SelectVBOXPathBtn.Size = new Size(151, 38);
            SelectVBOXPathBtn.TabIndex = 2;
            SelectVBOXPathBtn.Text = "Select Virtual Box";
            SelectVBOXPathBtn.UseVisualStyleBackColor = true;
            SelectVBOXPathBtn.Click += SelectVBOXPathBtn_Click;
            // 
            // SelectAIMPathBtn
            // 
            SelectAIMPathBtn.Location = new Point(6, 14);
            SelectAIMPathBtn.Name = "SelectAIMPathBtn";
            SelectAIMPathBtn.Size = new Size(151, 38);
            SelectAIMPathBtn.TabIndex = 1;
            SelectAIMPathBtn.Text = "Select Arsenal Image Mounter";
            SelectAIMPathBtn.UseVisualStyleBackColor = true;
            SelectAIMPathBtn.Click += SelectAIMPathBtn_Click;
            // 
            // EAgb
            // 
            EAgb.Controls.Add(linkLabel2);
            EAgb.Controls.Add(linkLabel1);
            EAgb.Controls.Add(AIMlbl);
            EAgb.Controls.Add(VVlbl);
            EAgb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EAgb.Location = new Point(6, 138);
            EAgb.Name = "EAgb";
            EAgb.Size = new Size(742, 126);
            EAgb.TabIndex = 0;
            EAgb.TabStop = false;
            EAgb.Text = "Required external applications";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(416, 74);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(320, 25);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://arsenalrecon.com/downloads";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(360, 30);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(376, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.virtualbox.org/wiki/Downloads";
            // 
            // AIMlbl
            // 
            AIMlbl.AutoSize = true;
            AIMlbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AIMlbl.Location = new Point(6, 74);
            AIMlbl.Name = "AIMlbl";
            AIMlbl.Size = new Size(310, 25);
            AIMlbl.TabIndex = 1;
            AIMlbl.Text = "Arsenal Image Mounter: aim_cli.exe";
            // 
            // VVlbl
            // 
            VVlbl.AutoSize = true;
            VVlbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            VVlbl.Location = new Point(6, 30);
            VVlbl.Name = "VVlbl";
            VVlbl.Size = new Size(263, 25);
            VVlbl.TabIndex = 0;
            VVlbl.Text = "Virtual Box:  VBoxManage.exe";
            // 
            // SelectSourceImageFileDialog
            // 
            SelectSourceImageFileDialog.Filter = resources.GetString("SelectSourceImageFileDialog.Filter");
            // 
            // MounterBackgroundWorker
            // 
            MounterBackgroundWorker.WorkerSupportsCancellation = true;
            MounterBackgroundWorker.DoWork += MounterBackgroundWorker_DoWork;
            // 
            // SelectDestinationImageFileDialog
            // 
            SelectDestinationImageFileDialog.DefaultExt = "vdi";
            // 
            // SelectAIMFileDialog
            // 
            SelectAIMFileDialog.FileName = "aim_cli.exe";
            SelectAIMFileDialog.Filter = "EXE|*.exe";
            // 
            // SelectVBOXFileDialog
            // 
            SelectVBOXFileDialog.FileName = "VBoxManage.exe";
            SelectVBOXFileDialog.Filter = "EXE|*.exe";
            // 
            // I2VFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 332);
            Controls.Add(I2VTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "I2VFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imm2Virtual 3.0 - Francesco Chiffi - Università degli Studi di Bari \"Aldo Moro\"";
            FormClosing += I2VFrm_FormClosing;
            I2VTab.ResumeLayout(false);
            ConversionPanel.ResumeLayout(false);
            ConversionPanel.PerformLayout();
            ConversionGB.ResumeLayout(false);
            ConversionGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KOCImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKCImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)KOMImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKMImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)KODImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKDImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)KOSImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKSImg).EndInit();
            LogPanel.ResumeLayout(false);
            LogPanel.PerformLayout();
            ConfigurationPanel.ResumeLayout(false);
            ConfigurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KOVBOXImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKVBOXImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)KOAIMImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKAIMImg).EndInit();
            EAgb.ResumeLayout(false);
            EAgb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl I2VTab;
        private TabPage ConversionPanel;
        private TabPage LogPanel;
        private TextBox logTxt;
        private Button SelectSourceImagePathBtn;
        private TextBox SourceImagePathTxt;
        private OpenFileDialog SelectSourceImageFileDialog;
        private System.ComponentModel.BackgroundWorker MounterBackgroundWorker;
        private SaveFileDialog SelectDestinationImageFileDialog;
        private Button SelectDestinationImagePathBtn;
        private TextBox DestinationImagePathTxt;
        private Button ConvertBtn;
        private PictureBox OKSImg;
        private PictureBox KOSImg;
        private PictureBox OKDImg;
        private PictureBox KODImg;
        private Label ConvertLbl;
        private Label MntLbl;
        private GroupBox ConversionGB;
        private PictureBox KOCImg;
        private PictureBox OKCImg;
        private PictureBox KOMImg;
        private PictureBox OKMImg;
        private TabPage ConfigurationPanel;
        private GroupBox EAgb;
        private Label AIMlbl;
        private Label VVlbl;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox VBOXPathTxt;
        private TextBox AIMPathTxt;
        private Button SelectVBOXPathBtn;
        private Button SelectAIMPathBtn;
        private PictureBox OKAIMImg;
        private PictureBox KOVBOXImg;
        private PictureBox OKVBOXImg;
        private PictureBox KOAIMImg;
        private OpenFileDialog SelectAIMFileDialog;
        private OpenFileDialog SelectVBOXFileDialog;
    }
}
