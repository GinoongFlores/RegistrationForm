using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Register : Form
    {
      

        public Register()
        {
            InitializeComponent();
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxUsername.Text = "";
            txtBxPassword.Text = "";
            txtBxConfirmPassword.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtBxUsername.Text != String.Empty && txtBxPassword.Text != String.Empty && txtBxConfirmPassword.Text != String.Empty)
            {
                if(txtBxPassword.Text == txtBxConfirmPassword.Text)
                {
                    con.Open();
                    string checkPassword = "SELECT * FROM tbl_users WHERE username='" + txtBxUsername.Text + "' AND password='" + txtBxPassword.Text + "'";
                    cmd = new OleDbCommand(checkPassword, con);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if(dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username is Already Exist, Please try again", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        dr.Close();

                        if (txtBxPassword.Text == txtBxConfirmPassword.Text)
                        {
                            MessageBox.Show("Password Matched!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        string register = "INSERT INTO tbl_users VALUES ('" + txtBxUsername.Text + "','" + txtBxPassword.Text + "')";
                        cmd = new OleDbCommand(register, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created, Please click the Login Below", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();

                }

                else
                {
                    MessageBox.Show("Password Not Matched!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            } 
            
            else
            {
                MessageBox.Show("Password or Username is Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
           // MessageBox.Show("Created an Account!", "Success", MessageBoxButtons.OK);

        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void chkBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShowPassword.Checked)
            {
                txtBxPassword.UseSystemPasswordChar = true;
                txtBxConfirmPassword.UseSystemPasswordChar = true;
            } else
            {
                txtBxPassword.UseSystemPasswordChar = false;
                txtBxConfirmPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
