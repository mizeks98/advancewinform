using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Handle.DataBase;
using Handle.DAL;

namespace ManageLibrary.DisplayForm
{
    public partial class Reader : DevExpress.XtraEditors.XtraForm
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInfoReader fr = new frmInfoReader();
            fr.Show();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = ReaderDAL.getListReader1();
            
            
        }
    }
}