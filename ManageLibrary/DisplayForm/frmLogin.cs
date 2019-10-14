using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String user = txtUsername.Text;
            String pass = txtPassword.Text;
            if (user == "admin" && pass == "123")
            {
                Main main = new Main();
                main.Show();
            }
            else
                MessageBox.Show("Username or Password is incorrect!");
        }
    }
}
