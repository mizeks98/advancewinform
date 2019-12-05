using ManageLibrary.DisplayForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class Main : Form
    {
        private const string V = "";

        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkExistForm("Reader"))
            {
                closeExistForm();
                Reader frm = new Reader();
                frm.MdiParent = this;
               
                frm.Show();
            }
            else
            {
                activateForm("Reader");
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkExistForm("Book"))
            {
                closeExistForm();
                Book frm = new Book();
                frm.MdiParent = this;

                frm.Show();
            }
            else
            {
                activateForm("Book");
            }
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private bool checkExistForm (string name)
        {
            foreach(Form fr in this.MdiChildren)
            {
                if (fr.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void closeExistForm()
        {
            foreach (Form fr in this.MdiChildren)
            {
               
                    fr.Close();
                
            }
        }
        private void activateForm(string name)
        {
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.Name == name)
                {
                    fr.Activate();
                    return;
                }
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkExistForm("Home"))
            {
                closeExistForm();
                Home frm = new Home();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activateForm("Home");
            }
        }
    }

    
}
