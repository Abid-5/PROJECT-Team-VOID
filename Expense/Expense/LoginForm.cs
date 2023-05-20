namespace Expense
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        string filePath = @"C:\Users\abids\OneDrive\Desktop\User.txt.txt";


        private bool CheckCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] == username && data[1] == password)
                {
                    return true;
                }
            }

            return false;
        }

        private void createAccLabel_Click_1(object sender, EventArgs e)
        {
            SignupForm s1 = new SignupForm();
            s1.Show();
            this.Hide();
        }

        private void logInButton_Click_1(object sender, EventArgs e)
        {
            if (CheckCredentials(usernameTextBox.Text, passwordTextBox.Text))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data[0] == usernameTextBox.Text)
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
