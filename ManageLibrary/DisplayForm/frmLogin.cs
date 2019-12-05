using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handle;

namespace ManageLibrary
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //String user = txtUsername.Text;
            //String pass = txtPassword.Text;
            //var login = db.MANAGE_USER.Where(p => p.IdUser.Equals(user) && p.PassWord.Equals(pass));
            //if (login.Count() != 0)
            //{
            //    this.Hide();
            //    Main main = new Main();
            //    main.ShowDialog();
            //}
            //else
            //    MessageBox.Show("Username or Password is incorrect! Please try again!");
        }
        private void chkb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_showpass.Checked)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
