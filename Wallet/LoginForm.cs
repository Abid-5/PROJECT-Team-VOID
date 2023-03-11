using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Wallet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoginForm_Load(object sender, EventArgs e)
        {
             
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" && PasswordTextBox.Text == "" && ConfirmPassTextBox.Text == "")
            {
                MessageBox.Show("Empty Username and password", "Registration failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (PasswordTextBox.Text == ConfirmPassTextBox.Text)
            {
                con.Open();
                string register ="INSERT INTO tbl_users VALUES ('"+UserNameTextBox.Text+"','"+PasswordTextBox.Text+ "')";
                cmd=new OleDbCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();

                UserNameTextBox.Text = "";
                PasswordTextBox.Text = "";
                ConfirmPassTextBox.Text = "";

                MessageBox.Show("Account created successfully", "Registration success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match, please Re-enter", "Registration failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                PasswordTextBox.Text = "";
                ConfirmPassTextBox.Text = "";
                PasswordTextBox.Focus();
            }
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPassTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '•';
                ConfirmPassTextBox.PasswordChar = '•';
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPassTextBox.Text = "";
            UserNameTextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
