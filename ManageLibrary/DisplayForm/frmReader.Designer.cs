namespace ManageLibrary.DisplayForm
{
    partial class frmReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReader));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgv_reader = new System.Windows.Forms.DataGridView();
            this.colStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NameReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Realeas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpiryDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteReader = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditReader = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddReader = new DevExpress.XtraEditors.SimpleButton();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BorrowDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgv_reader);
            this.panelControl1.Controls.Add(this.btnDeleteReader);
            this.panelControl1.Controls.Add(this.btnEditReader);
            this.panelControl1.Controls.Add(this.btnAddReader);
            this.panelControl1.Location = new System.Drawing.Point(5, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 384);
            this.panelControl1.TabIndex = 0;
            // 
            // dgv_reader
            // 
            this.dgv_reader.AllowUserToOrderColumns = true;
            this.dgv_reader.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_reader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_reader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStt,
            this.col_IdCard,
            this.col_NameReader,
            this.col_Class,
            this.col_Gender,
            this.col_birthday,
            this.col_Realeas,
            this.col_ExpiryDay});
            this.dgv_reader.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_reader.Location = new System.Drawing.Point(0, 40);
            this.dgv_reader.Name = "dgv_reader";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reader.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgv_reader.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_reader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_reader.Size = new System.Drawing.Size(1259, 305);
            this.dgv_reader.TabIndex = 31;
            // 
            // colStt
            // 
            this.colStt.HeaderText = "STT";
            this.colStt.Name = "colStt";
            // 
            // col_IdCard
            // 
            this.col_IdCard.HeaderText = "ID Card";
            this.col_IdCard.Name = "col_IdCard";
            // 
            // col_NameReader
            // 
            this.col_NameReader.HeaderText = "Name\'s Reader";
            this.col_NameReader.Name = "col_NameReader";
            // 
            // col_Class
            // 
            this.col_Class.HeaderText = "Class";
            this.col_Class.Name = "col_Class";
            // 
            // col_Gender
            // 
            this.col_Gender.HeaderText = "Gender";
            this.col_Gender.Name = "col_Gender";
            // 
            // col_birthday
            // 
            this.col_birthday.HeaderText = "Day of Birth";
            this.col_birthday.Name = "col_birthday";
            // 
            // col_Realeas
            // 
            this.col_Realeas.HeaderText = "Realeas Day";
            this.col_Realeas.Name = "col_Realeas";
            // 
            // col_ExpiryDay
            // 
            this.col_ExpiryDay.HeaderText = "Expiry Day";
            this.col_ExpiryDay.Name = "col_ExpiryDay";
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteReader.ImageOptions.SvgImage")));
            this.btnDeleteReader.Location = new System.Drawing.Point(188, 5);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteReader.TabIndex = 30;
            this.btnDeleteReader.Text = "Delete";
            // 
            // btnEditReader
            // 
            this.btnEditReader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditReader.ImageOptions.SvgImage")));
            this.btnEditReader.Location = new System.Drawing.Point(106, 5);
            this.btnEditReader.Name = "btnEditReader";
            this.btnEditReader.Size = new System.Drawing.Size(76, 29);
            this.btnEditReader.TabIndex = 29;
            this.btnEditReader.Text = "Edit";
            // 
            // btnAddReader
            // 
            this.btnAddReader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddReader.ImageOptions.SvgImage")));
            this.btnAddReader.Location = new System.Drawing.Point(6, 5);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(94, 29);
            this.btnAddReader.TabIndex = 28;
            this.btnAddReader.Text = "Add new";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reader List";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Location = new System.Drawing.Point(5, 469);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1259, 222);
            this.panelControl2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(6, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "History of borrow and return books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.col_IdBook,
            this.col_NameBook,
            this.col_Author,
            this.col_BorrowDay,
            this.col_Return,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(7, 5);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 186);
            this.dataGridView1.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // col_IdBook
            // 
            this.col_IdBook.HeaderText = "ID Book";
            this.col_IdBook.Name = "col_IdBook";
            // 
            // col_NameBook
            // 
            this.col_NameBook.HeaderText = "Name\'s Book";
            this.col_NameBook.Name = "col_NameBook";
            // 
            // col_Author
            // 
            this.col_Author.HeaderText = "Author";
            this.col_Author.Name = "col_Author";
            // 
            // col_BorrowDay
            // 
            this.col_BorrowDay.HeaderText = "Borrow Date";
            this.col_BorrowDay.Name = "col_BorrowDay";
            // 
            // col_Return
            // 
            this.col_Return.HeaderText = "Appointment Date";
            this.col_Return.Name = "col_Return";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Pay Day";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 694);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmReader";
            this.Text = "Reader";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteReader;
        private DevExpress.XtraEditors.SimpleButton btnEditReader;
        private DevExpress.XtraEditors.SimpleButton btnAddReader;
        private System.Windows.Forms.DataGridView dgv_reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NameReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Realeas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpiryDay;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BorrowDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}