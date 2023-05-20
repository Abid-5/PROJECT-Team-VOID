using System.Security.Cryptography.X509Certificates;

namespace Expense
{
    public partial class Main : Form
    {
        List<string> category = new List<string>();
        public decimal budget;

        private List<Expense> expenses = new List<Expense>();

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //decimal budget;

                budget = Convert.ToDecimal(BudgetTextBox.Text);
                category.Add(CategoryTextBox.Text);
                CategoryList.Items.Add(CategoryTextBox.Text);

                MessageBox.Show("Successfully added");
                BudgetTextBox.Clear();
                CategoryTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Expense expense = new Expense();
                expense.Amount = 0;
                expense.Category = CategoryList.Text;
                expense.Budget = budget;


                // AmountTextbox.Clear();


                expenses.Add(expense);
                //string s = $"{expense.Category}     {expense.Budget}    {expense.Amount}";
                //listBox1.Items.Add(s);
                bool matched = false;
                foreach (var item in expenses)
                {

                    if (item.Category == CategoryList.Text)
                    {
                        var newamount = Convert.ToDecimal(AmountTextbox.Text) + Convert.ToDecimal(item.Amount);
                        item.Amount = newamount;
                        string s = $"{expense.Category}             {expense.Budget}            {newamount}";
                        listBox1.Items.Add(s);
                        AmountTextbox.Clear();
                        if (newamount > expense.Budget)
                        {
                            MessageBox.Show("Warning!!! Budget Limit Crossed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            listBox1.Items.Add("BUDGET LIMIT CROSSED");
                        }
                        else
                        {
                            MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        matched = true;
                        return;
                    }
                }
                if (matched == false)
                {
                    string s = $"{expense.Category}     {expense.Budget}    {expense.Amount}";
                    listBox1.Items.Add(s);
                    AmountTextbox.Clear();
                    MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Income income = new Income();
                income.source = IncomeSourceTextBox.Text;
                income.amount = Convert.ToDecimal(IncomeAmountTextBox.Text);
                string i = $"{income.amount}                            {income.source}";
                listBox2.Items.Add(i);
                IncomeSourceTextBox.Clear();
                IncomeAmountTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }

}