namespace Expense
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddIncomeButton = new Button();
            AddExpenseButton = new Button();
            ExpenseCategory = new Button();
            SuspendLayout();
            // 
            // AddIncomeButton
            // 
            AddIncomeButton.Location = new Point(801, 35);
            AddIncomeButton.Name = "AddIncomeButton";
            AddIncomeButton.Size = new Size(175, 89);
            AddIncomeButton.TabIndex = 0;
            AddIncomeButton.Text = "Add Income";
            AddIncomeButton.UseVisualStyleBackColor = true;
            // 
            // AddExpenseButton
            // 
            AddExpenseButton.Location = new Point(801, 260);
            AddExpenseButton.Name = "AddExpenseButton";
            AddExpenseButton.Size = new Size(175, 93);
            AddExpenseButton.TabIndex = 1;
            AddExpenseButton.Text = "Add Expense";
            AddExpenseButton.UseVisualStyleBackColor = true;
            AddExpenseButton.Click += AddExpenseButton_Click;
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.Location = new Point(801, 144);
            ExpenseCategory.Name = "ExpenseCategory";
            ExpenseCategory.Size = new Size(175, 93);
            ExpenseCategory.TabIndex = 2;
            ExpenseCategory.Text = "Add Expense Category";
            ExpenseCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 531);
            Controls.Add(ExpenseCategory);
            Controls.Add(AddExpenseButton);
            Controls.Add(AddIncomeButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddIncomeButton;
        private Button AddExpenseButton;
        private Button ExpenseCategory;
    }
}