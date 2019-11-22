using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace ManageLibrary.DisplayForm
{
    public partial class ucReadercs : DevExpress.XtraEditors.XtraUserControl
    {
        public ucReadercs()
        {
            InitializeComponent();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            frmInfoReader frm = new frmInfoReader();
            frm.ShowDialog();
        }
    }
}
