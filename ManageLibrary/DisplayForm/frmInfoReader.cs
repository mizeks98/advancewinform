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
    public partial class frmInfoReader : DevExpress.XtraEditors.XtraForm
    {
        public frmInfoReader()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInfoReader_Load(object sender, EventArgs e)
        {
            cbbClass.DataSource = ClassDAL.getListReader();
            cbbClass.ValueMember = "idClass";
            cbbClass.DisplayMember = "nameClass";
        }

        string tempIDReader = "DA0";
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            READER reader = new READER();
            CARD card = new CARD();

            var tempReader = Connection.db.READERS.Count();


            reader.idReader = tempIDReader + tempReader; 
            reader.nameReader = txtFirstName.Text + txtLastName.Text;
            reader.idClass = cbbClass.SelectedValue.ToString();
            if (cbbSex.SelectedText == "Male")
                reader.sex = false;
            else
                reader.sex = true;
            reader.birthday = Convert.ToDateTime(dtpBirthday.Text);
            reader.address = txtAddress.Text;
            ReaderDAL.addNewReader(reader);
               


            
        }
    }
}