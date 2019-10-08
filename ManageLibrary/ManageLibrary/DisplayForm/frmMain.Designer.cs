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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.pnShowMain = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnShowMain
            // 
            this.pnShowMain.Location = new System.Drawing.Point(12, 92);
            this.pnShowMain.Name = "pnShowMain";
            this.pnShowMain.Size = new System.Drawing.Size(1233, 716);
            this.pnShowMain.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            toolTipItem1.Text = "1";
            toolTipTitleItem1.Text = "1";
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipTitleItem1);
            toolTipItem2.Text = "2";
            toolTipTitleItem2.Text = "2";
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "1", 1, true, superToolTip1, true, false, true, null, 1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "2", 2, true, superToolTip2, true, false, true, null, 2),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 3, true, null, true, false, true, null, 3),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton()});
            this.groupControl1.Location = new System.Drawing.Point(25, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(642, 41);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = " ";
            this.groupControl1.Click += new System.EventHandler(this.groupControl1_Click);
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint_1);
            // 
            // Main
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1257, 820);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnShowMain);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShowMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}