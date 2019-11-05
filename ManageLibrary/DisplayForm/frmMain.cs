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

        private void btnBook_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (System.Windows.Forms.UserControl uc in pnShowMain.Controls)
                {
                    pnShowMain.Controls.Remove(uc);
                }
                ucBooks ucI = new ucBooks();
                ucI.Dock = DockStyle.Fill;
                pnShowMain.Controls.Add(ucI);
                pnShowMain.Controls["ucBooks"].BringToFront();
            }
            catch (Exception ex)
            {
            }
        }   

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkArea_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (System.Windows.Forms.UserControl uc in pnShowMain.Controls)
                {
                    pnShowMain.Controls.Remove(uc);
                }
                ucWorkingArea ucI = new ucWorkingArea();
                ucI.Dock = DockStyle.Fill;
                pnShowMain.Controls.Add(ucI);
                pnShowMain.Controls["ucWorkingArea"].BringToFront();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (System.Windows.Forms.UserControl uc in pnShowMain.Controls)
                {
                    pnShowMain.Controls.Remove(uc);
                }
                ucBooks ucI = new ucBooks();
                ucI.Dock = DockStyle.Fill;
                pnShowMain.Controls.Add(ucI);
                pnShowMain.Controls["ucBooks"].BringToFront();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnReader_Click(object sender, EventArgs e)
        {

        }
    }

    
}
