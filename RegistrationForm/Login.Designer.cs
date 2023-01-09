namespace RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBxShowPassword = new System.Windows.Forms.CheckBox();
            this.createAccount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(30, 111);
            this.txtBxUsername.Multiline = true;
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(251, 30);
            this.txtBxUsername.TabIndex = 1;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(30, 195);
            this.txtBxPassword.Multiline = true;
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(251, 30);
            this.txtBxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(30, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(251, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(30, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(251, 48);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBxShowPassword
            // 
            this.txtBxShowPassword.AutoSize = true;
            this.txtBxShowPassword.Location = new System.Drawing.Point(30, 231);
            this.txtBxShowPassword.Name = "txtBxShowPassword";
            this.txtBxShowPassword.Size = new System.Drawing.Size(143, 24);
            this.txtBxShowPassword.TabIndex = 3;
            this.txtBxShowPassword.Text = "Show Password";
            this.txtBxShowPassword.UseVisualStyleBackColor = true;
            this.txtBxShowPassword.CheckedChanged += new System.EventHandler(this.txtBxShowPassword_CheckedChanged);
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createAccount.Location = new System.Drawing.Point(92, 494);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(124, 20);
            this.createAccount.TabIndex = 6;
            this.createAccount.Text = "Create Account";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(276, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.txtBxShowPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox txtBxShowPassword;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Button btnExit;
    }
}