namespace Expense
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button1 = new Button();
            createAccLabel = new Label();
            label3 = new Label();
            logInButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(107, 252);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(158, 44);
            button1.TabIndex = 20;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.BackColor = Color.Transparent;
            createAccLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            createAccLabel.ForeColor = Color.Red;
            createAccLabel.Location = new Point(213, 207);
            createAccLabel.Margin = new Padding(2, 0, 2, 0);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(113, 24);
            createAccLabel.TabIndex = 19;
            createAccLabel.Text = "Create one";
            createAccLabel.Click += createAccLabel_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 207);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 18;
            label3.Text = "Don't have an account? ";
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.SpringGreen;
            logInButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.Location = new Point(107, 132);
            logInButton.Margin = new Padding(2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(158, 44);
            logInButton.TabIndex = 17;
            logInButton.Text = "Login";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click_1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(154, 66);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(172, 26);
            passwordTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(154, 19);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(172, 26);
            usernameTextBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 13;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 14;
            label1.Text = "Username:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(370, 312);
            Controls.Add(button1);
            Controls.Add(createAccLabel);
            Controls.Add(label3);
            Controls.Add(logInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label createAccLabel;
        private Label label3;
        private Button logInButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
    }
}