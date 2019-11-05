namespace ManageLibrary
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnSignup = new DevExpress.XtraEditors.SimpleButton();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkb_showpass = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkb_showpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Appearance.Options.UseFont = true;
            this.btnSignup.Location = new System.Drawing.Point(216, 202);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(86, 36);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lbUsername.Appearance.Options.UseFont = true;
            this.lbUsername.Appearance.Options.UseForeColor = true;
            this.lbUsername.Location = new System.Drawing.Point(107, 95);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(83, 23);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lbPassword.Appearance.Options.UseFont = true;
            this.lbPassword.Appearance.Options.UseForeColor = true;
            this.lbPassword.Location = new System.Drawing.Point(107, 138);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(80, 23);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Appearance.Options.UseFont = true;
            this.btnSignIn.Location = new System.Drawing.Point(342, 202);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(87, 36);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(228, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 32);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(228, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 32);
            this.txtPassword.TabIndex = 2;
            // 
            // chkb_showpass
            // 
            this.chkb_showpass.Location = new System.Drawing.Point(459, 144);
            this.chkb_showpass.Name = "chkb_showpass";
            this.chkb_showpass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_showpass.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.chkb_showpass.Properties.Appearance.Options.UseFont = true;
            this.chkb_showpass.Properties.Appearance.Options.UseForeColor = true;
            this.chkb_showpass.Properties.Caption = "show";
            this.chkb_showpass.Size = new System.Drawing.Size(75, 27);
            this.chkb_showpass.TabIndex = 6;
            this.chkb_showpass.CheckedChanged += new System.EventHandler(this.chkb_showpass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 432);
            this.Controls.Add(this.chkb_showpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnSignup);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.chkb_showpass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSignup;
        private DevExpress.XtraEditors.LabelControl lbUsername;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.SimpleButton btnSignIn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkb_showpass;
    }
}

