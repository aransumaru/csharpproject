namespace Project
{
    partial class Login
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
            loginButton = new Button();
            signupButton = new Button();
            button3 = new Button();
            usernameText = new TextBox();
            passwordText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(132, 221);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(255, 221);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(94, 29);
            signupButton.TabIndex = 1;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(167, 279);
            button3.Name = "button3";
            button3.Size = new Size(136, 29);
            button3.TabIndex = 2;
            button3.Text = "Forgot Password";
            button3.UseVisualStyleBackColor = true;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(224, 118);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(125, 27);
            usernameText.TabIndex = 3;
            usernameText.TextChanged += usernameText_TextChanged;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(224, 160);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(125, 27);
            passwordText.TabIndex = 4;
            passwordText.TextChanged += passwordText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 121);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(button3);
            Controls.Add(signupButton);
            Controls.Add(loginButton);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button signupButton;
        private Button button3;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label label1;
        private Label label2;
    }
}