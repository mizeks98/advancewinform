namespace ManageLibrary
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnShowMain = new System.Windows.Forms.Panel();
            this.grbBtn = new System.Windows.Forms.GroupBox();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReader = new DevExpress.XtraEditors.SimpleButton();
            this.btnCirculate = new DevExpress.XtraEditors.SimpleButton();
            this.btnBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnWorkArea = new DevExpress.XtraEditors.SimpleButton();
            this.grbBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShowMain
            // 
            this.pnShowMain.Location = new System.Drawing.Point(12, 52);
            this.pnShowMain.Name = "pnShowMain";
            this.pnShowMain.Size = new System.Drawing.Size(1233, 756);
            this.pnShowMain.TabIndex = 0;
            // 
            // grbBtn
            // 
            this.grbBtn.Controls.Add(this.btnReport);
            this.grbBtn.Controls.Add(this.btnSetting);
            this.grbBtn.Controls.Add(this.btnList);
            this.grbBtn.Controls.Add(this.simpleButton1);
            this.grbBtn.Controls.Add(this.btnReader);
            this.grbBtn.Controls.Add(this.btnCirculate);
            this.grbBtn.Controls.Add(this.btnBook);
            this.grbBtn.Controls.Add(this.btnWorkArea);
            this.grbBtn.Location = new System.Drawing.Point(12, 12);
            this.grbBtn.Name = "grbBtn";
            this.grbBtn.Size = new System.Drawing.Size(695, 34);
            this.grbBtn.TabIndex = 13;
            this.grbBtn.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.Location = new System.Drawing.Point(600, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 29);
            this.btnReport.TabIndex = 27;
            this.btnReport.Text = "Report";
            // 
            // btnSetting
            // 
            this.btnSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSetting.ImageOptions.SvgImage")));
            this.btnSetting.Location = new System.Drawing.Point(500, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(94, 29);
            this.btnSetting.TabIndex = 26;
            this.btnSetting.Text = "Setting";
            // 
            // btnList
            // 
            this.btnList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnList.ImageOptions.SvgImage")));
            this.btnList.Location = new System.Drawing.Point(400, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(94, 29);
            this.btnList.TabIndex = 25;
            this.btnList.Text = "List";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(400, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "List";
            // 
            // btnReader
            // 
            this.btnReader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReader.ImageOptions.SvgImage")));
            this.btnReader.Location = new System.Drawing.Point(300, 3);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(94, 29);
            this.btnReader.TabIndex = 23;
            this.btnReader.Text = "Reader";
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnCirculate
            // 
            this.btnCirculate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculate.ImageOptions.Image")));
            this.btnCirculate.Location = new System.Drawing.Point(200, 3);
            this.btnCirculate.Name = "btnCirculate";
            this.btnCirculate.Size = new System.Drawing.Size(94, 29);
            this.btnCirculate.TabIndex = 22;
            this.btnCirculate.Text = "Circulate";
            // 
            // btnBook
            // 
            this.btnBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.ImageOptions.Image")));
            this.btnBook.Location = new System.Drawing.Point(100, 3);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(94, 29);
            this.btnBook.TabIndex = 21;
            this.btnBook.Text = "Book";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnWorkArea
            // 
            this.btnWorkArea.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWorkArea.ImageOptions.SvgImage")));
            this.btnWorkArea.Location = new System.Drawing.Point(0, 3);
            this.btnWorkArea.Name = "btnWorkArea";
            this.btnWorkArea.Size = new System.Drawing.Size(94, 29);
            this.btnWorkArea.TabIndex = 20;
            this.btnWorkArea.Text = "Work Area";
            this.btnWorkArea.Click += new System.EventHandler(this.btnWorkArea_Click);
            // 
            // Main
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1257, 749);
            this.Controls.Add(this.grbBtn);
            this.Controls.Add(this.pnShowMain);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grbBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShowMain;
        private System.Windows.Forms.GroupBox grbBtn;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnSetting;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnReader;
        private DevExpress.XtraEditors.SimpleButton btnCirculate;
        private DevExpress.XtraEditors.SimpleButton btnBook;
        private DevExpress.XtraEditors.SimpleButton btnWorkArea;
    }
}