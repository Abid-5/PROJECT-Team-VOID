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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            AddIncomeButton = new Button();
            button1 = new Button();
            AmountTextbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CategoryList = new ComboBox();
            BudgetTextBox = new TextBox();
            label3 = new Label();
            button2 = new Button();
            CategoryTextBox = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            IncomeSourceTextBox = new TextBox();
            label5 = new Label();
            IncomeAmountTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // AddIncomeButton
            // 
            AddIncomeButton.BackColor = Color.MediumPurple;
            AddIncomeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddIncomeButton.ForeColor = SystemColors.ControlLightLight;
            AddIncomeButton.Location = new Point(807, 125);
            AddIncomeButton.Name = "AddIncomeButton";
            AddIncomeButton.Size = new Size(150, 30);
            AddIncomeButton.TabIndex = 0;
            AddIncomeButton.Text = "Add Income";
            AddIncomeButton.UseVisualStyleBackColor = false;
            AddIncomeButton.Click += AddIncomeButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(807, 413);
            button1.Name = "button1";
            button1.Size = new Size(150, 32);
            button1.TabIndex = 9;
            button1.Text = "Add Expense";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AmountTextbox
            // 
            AmountTextbox.Location = new Point(807, 371);
            AmountTextbox.Name = "AmountTextbox";
            AmountTextbox.Size = new Size(177, 23);
            AmountTextbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(728, 374);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Amout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(710, 328);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 6;
            label1.Text = "Category";
            // 
            // CategoryList
            // 
            CategoryList.FormattingEnabled = true;
            CategoryList.Location = new Point(807, 325);
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(177, 23);
            CategoryList.TabIndex = 5;
            // 
            // BudgetTextBox
            // 
            BudgetTextBox.Location = new Point(807, 210);
            BudgetTextBox.Name = "BudgetTextBox";
            BudgetTextBox.Size = new Size(170, 23);
            BudgetTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(728, 213);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 13;
            label3.Text = "Budget";
            // 
            // button2
            // 
            button2.BackColor = Color.HotPink;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(807, 239);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 12;
            button2.Text = "Add Expense Category";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(807, 170);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(170, 23);
            CategoryTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(714, 173);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Category\tBudget Spent" });
            listBox1.Location = new Point(36, 291);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 154);
            listBox1.TabIndex = 15;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Items.AddRange(new object[] { "Amount\t\tSource" });
            listBox2.Location = new Point(36, 54);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(455, 154);
            listBox2.TabIndex = 16;
            // 
            // IncomeSourceTextBox
            // 
            IncomeSourceTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            IncomeSourceTextBox.Location = new Point(804, 46);
            IncomeSourceTextBox.Name = "IncomeSourceTextBox";
            IncomeSourceTextBox.Size = new Size(170, 33);
            IncomeSourceTextBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(674, 54);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 17;
            label5.Text = "Income Source";
            // 
            // IncomeAmountTextBox
            // 
            IncomeAmountTextBox.Location = new Point(800, 90);
            IncomeAmountTextBox.Name = "IncomeAmountTextBox";
            IncomeAmountTextBox.Size = new Size(177, 23);
            IncomeAmountTextBox.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(728, 93);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 19;
            label6.Text = "Amout";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Apple SD Gothic Neo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Orange;
            label7.Location = new Point(36, 18);
            label7.Name = "label7";
            label7.Size = new Size(94, 29);
            label7.TabIndex = 21;
            label7.Text = "Income";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Apple SD Gothic Neo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSkyBlue;
            label8.Location = new Point(36, 249);
            label8.Name = "label8";
            label8.Size = new Size(104, 29);
            label8.TabIndex = 22;
            label8.Text = "Expense";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1009, 466);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(IncomeAmountTextBox);
            Controls.Add(label6);
            Controls.Add(IncomeSourceTextBox);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(BudgetTextBox);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(CategoryTextBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(AmountTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CategoryList);
            Controls.Add(AddIncomeButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Wallet";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddIncomeButton;
        private Button button1;
        private TextBox AmountTextbox;
        private Label label2;
        private Label label1;
        private ComboBox CategoryList;
        private TextBox BudgetTextBox;
        private Label label3;
        private Button button2;
        private TextBox CategoryTextBox;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox IncomeSourceTextBox;
        private Label label5;
        private TextBox IncomeAmountTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}