namespace Project
{
    partial class NodeManagement
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
            scoremanagerButton = new Button();
            studentmanagerButton = new Button();
            SuspendLayout();
            // 
            // scoremanagerButton
            // 
            scoremanagerButton.Location = new Point(145, 122);
            scoremanagerButton.Name = "scoremanagerButton";
            scoremanagerButton.Size = new Size(139, 88);
            scoremanagerButton.TabIndex = 0;
            scoremanagerButton.Text = "Score Manager";
            scoremanagerButton.UseVisualStyleBackColor = true;
            scoremanagerButton.Click += scoremanagerButton_Click;
            // 
            // studentmanagerButton
            // 
            studentmanagerButton.Location = new Point(314, 122);
            studentmanagerButton.Name = "studentmanagerButton";
            studentmanagerButton.Size = new Size(139, 88);
            studentmanagerButton.TabIndex = 1;
            studentmanagerButton.Text = "Student Manager";
            studentmanagerButton.UseVisualStyleBackColor = true;
            studentmanagerButton.Click += studentmanagerButton_Click;
            // 
            // NodeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentmanagerButton);
            Controls.Add(scoremanagerButton);
            Name = "NodeManagement";
            Text = "NodeManagement";
            ResumeLayout(false);
        }

        #endregion

        private Button scoremanagerButton;
        private Button studentmanagerButton;
    }
}