namespace Expense
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            reTypePassTextBox1 = new TextBox();
            label6 = new Label();
            nameTextBox = new TextBox();
            label5 = new Label();
            loginLabel = new Label();
            label3 = new Label();
            signupButton = new Button();
            passwordTextBox1 = new TextBox();
            usernameTextBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // reTypePassTextBox1
            // 
            reTypePassTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reTypePassTextBox1.Location = new Point(190, 166);
            reTypePassTextBox1.Margin = new Padding(2);
            reTypePassTextBox1.Name = "reTypePassTextBox1";
            reTypePassTextBox1.Size = new Size(172, 26);
            reTypePassTextBox1.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 166);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 36;
            label6.Text = "Re-type password:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(190, 27);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(172, 26);
            nameTextBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(113, 27);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 34;
            label5.Text = "Name:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.Red;
            loginLabel.Location = new Point(272, 277);
            loginLabel.Margin = new Padding(2, 0, 2, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(58, 20);
            loginLabel.TabIndex = 33;
            loginLabel.Text = "Log In!";
            loginLabel.Click += loginLabel_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 277);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 32;
            label3.Text = "Already have an account?";
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.DeepSkyBlue;
            signupButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            signupButton.Location = new Point(127, 213);
            signupButton.Margin = new Padding(2);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(158, 44);
            signupButton.TabIndex = 31;
            signupButton.Text = "Sign UP";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // passwordTextBox1
            // 
            passwordTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox1.Location = new Point(190, 117);
            passwordTextBox1.Margin = new Padding(2);
            passwordTextBox1.Name = "passwordTextBox1";
            passwordTextBox1.Size = new Size(172, 26);
            passwordTextBox1.TabIndex = 29;
            // 
            // usernameTextBox1
            // 
            usernameTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox1.Location = new Point(190, 71);
            usernameTextBox1.Margin = new Padding(2);
            usernameTextBox1.Name = "usernameTextBox1";
            usernameTextBox1.Size = new Size(172, 26);
            usernameTextBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 27;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 28;
            label1.Text = "Username:";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(384, 337);
            Controls.Add(reTypePassTextBox1);
            Controls.Add(label6);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(loginLabel);
            Controls.Add(label3);
            Controls.Add(signupButton);
            Controls.Add(passwordTextBox1);
            Controls.Add(usernameTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reTypePassTextBox1;
        private Label label6;
        private TextBox nameTextBox;
        private Label label5;
        private Label loginLabel;
        private Label label3;
        private Button signupButton;
        private TextBox passwordTextBox1;
        private TextBox usernameTextBox1;
        private Label label2;
        private Label label1;
    }
}