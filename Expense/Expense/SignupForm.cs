using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }


        string filePath = @"C:\Users\abids\OneDrive\Desktop\User.txt.txt";



        private bool UserExists(string username)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] == username)
                {
                    return true;
                }
            }

            return false;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();


            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox1.Text) || string.IsNullOrWhiteSpace(reTypePassTextBox1.Text))
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserExists(usernameTextBox1.Text))
            {
                MessageBox.Show("A user with the same user name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordTextBox1.Text != reTypePassTextBox1.Text)
            {
                MessageBox.Show("passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordTextBox1.TextLength < 6 || reTypePassTextBox1.TextLength < 6)
            {
                MessageBox.Show("Password must be at least six characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lines.Add($"{usernameTextBox1.Text},{passwordTextBox1.Text},{nameTextBox.Text}");
            File.WriteAllLines(filePath, lines);

            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void loginLabel_Click_1(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            l1.Show();
            this.Hide();
        }
    }
}
