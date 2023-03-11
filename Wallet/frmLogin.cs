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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + UserNameTextBox.Text + " ' and password= '" +
                           PasswordTextBox.Text + "'";
            cmd= new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password, Please try again", "Login Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                UserNameTextBox.Text = "";
                PasswordTextBox.Text = "";
                UserNameTextBox.Focus();
            }
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
                //ConfirmPassTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '•';
               // ConfirmPassTextBox.PasswordChar = '•';
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            UserNameTextBox.Focus();
        }
    }
}
