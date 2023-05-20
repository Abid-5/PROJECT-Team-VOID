namespace Expense
{
    partial class ExCategory
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
            label1 = new Label();
            CategoryTextBox2 = new TextBox();
            button1 = new Button();
            BudgetTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // CategoryTextBox2
            // 
            CategoryTextBox2.Location = new Point(104, 41);
            CategoryTextBox2.Name = "CategoryTextBox2";
            CategoryTextBox2.Size = new Size(170, 23);
            CategoryTextBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(104, 110);
            button1.Name = "button1";
            button1.Size = new Size(144, 39);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // BudgetTextBox
            // 
            BudgetTextBox.Location = new Point(104, 81);
            BudgetTextBox.Name = "BudgetTextBox";
            BudgetTextBox.Size = new Size(170, 23);
            BudgetTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Budget";
            // 
            // ExCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 161);
            Controls.Add(BudgetTextBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(CategoryTextBox2);
            Controls.Add(label1);
            Name = "ExCategory";
            Text = "ExCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CategoryTextBox2;
        private Button button1;
        private TextBox BudgetTextBox;
        private Label label2;
    }
}