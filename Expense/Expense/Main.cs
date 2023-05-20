namespace Expense
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            AddExpense form2 = new AddExpense();
            form2.ShowDialog();
        }
    }

}