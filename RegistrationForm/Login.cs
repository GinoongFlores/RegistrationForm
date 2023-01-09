using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");


        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.ShowDialog();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username='" + txtBxUsername.Text + "' AND password='" + txtBxPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

           if (dr.Read() == true) {
                this.Hide();
                new AnotherForm().Show();
            } else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxPassword.Text = "";
                txtBxUsername.Text = "";
                txtBxUsername.Focus();
            }

            con.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxPassword.Text = "";
            txtBxUsername.Text = "";
        }

        private void txtBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBxShowPassword.Checked)
            {
               txtBxPassword.UseSystemPasswordChar = true;
            } else
            {
                txtBxPassword.UseSystemPasswordChar = false; 
            }
        }

      
    }
}
