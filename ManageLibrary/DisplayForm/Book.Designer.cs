namespace ManageLibrary.DisplayForm
{
    partial class Book
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Drawing.StubGlyphOptions stubGlyphOptions1 = new DevExpress.Utils.Drawing.StubGlyphOptions();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.group2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.group1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnViewOfSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewOfList = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group2)).BeginInit();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1)).BeginInit();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.45F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.55F)});
            this.tablePanel1.Controls.Add(this.group2);
            this.tablePanel1.Controls.Add(this.group1);
            this.tablePanel1.Controls.Add(this.layoutControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1274, 656);
            this.tablePanel1.TabIndex = 0;
            // 
            // group2
            // 
            this.tablePanel1.SetColumn(this.group2, 1);
            this.group2.Controls.Add(this.gridControl1);
            this.group2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group2.Location = new System.Drawing.Point(267, 53);
            this.group2.Name = "group2";
            this.tablePanel1.SetRow(this.group2, 1);
            this.group2.Size = new System.Drawing.Size(1004, 600);
            this.group2.TabIndex = 2;
            this.group2.Text = "Book in Library";
            this.group2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 578);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // group1
            // 
            this.group1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.group1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.group1, 0);
            this.group1.Controls.Add(this.treeList1);
            this.group1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group1.Location = new System.Drawing.Point(3, 53);
            this.group1.Name = "group1";
            this.tablePanel1.SetRow(this.group1, 1);
            this.group1.Size = new System.Drawing.Size(258, 600);
            this.group1.TabIndex = 1;
            this.group1.Text = "Type of Book";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 20);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(254, 578);
            this.treeList1.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.behaviorManager1.SetBehaviors(this.treeListColumn1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(typeof(DevExpress.XtraTreeList.BehaviorSource.StubGlyphBehaviorSourceForTreeListColumn), stubGlyphOptions1, new System.Drawing.Size(16, 16))))});
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // layoutControl1
            // 
            this.tablePanel1.SetColumn(this.layoutControl1, 0);
            this.layoutControl1.Controls.Add(this.btnViewOfSearch);
            this.layoutControl1.Controls.Add(this.btnViewOfList);
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.layoutControl1, 0);
            this.layoutControl1.Size = new System.Drawing.Size(258, 44);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnViewOfSearch
            // 
            this.btnViewOfSearch.Location = new System.Drawing.Point(122, 12);
            this.btnViewOfSearch.Name = "btnViewOfSearch";
            this.btnViewOfSearch.Size = new System.Drawing.Size(107, 22);
            this.btnViewOfSearch.StyleController = this.layoutControl1;
            this.btnViewOfSearch.TabIndex = 1;
            this.btnViewOfSearch.Text = "View of Search";
            // 
            // btnViewOfList
            // 
            this.btnViewOfList.Location = new System.Drawing.Point(12, 12);
            this.btnViewOfList.Name = "btnViewOfList";
            this.btnViewOfList.Size = new System.Drawing.Size(106, 22);
            this.btnViewOfList.StyleController = this.layoutControl1;
            this.btnViewOfList.TabIndex = 1;
            this.btnViewOfList.Text = "View of List";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(241, 56);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnViewOfList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(110, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnViewOfSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(110, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(111, 36);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Book
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 656);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.Name = "Book";
            this.Text = "Book Manager";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group2)).EndInit();
            this.group2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1)).EndInit();
            this.group1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnViewOfSearch;
        private DevExpress.XtraEditors.SimpleButton btnViewOfList;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GroupControl group1;
        private DevExpress.XtraEditors.GroupControl group2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}