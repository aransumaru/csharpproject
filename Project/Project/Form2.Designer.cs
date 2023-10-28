namespace Project
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            cbStudent = new ComboBox();
            label1 = new Label();
            studentName = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dobTime = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(786, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(105, 48);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(113, 28);
            cbStudent.TabIndex = 1;
            cbStudent.SelectedIndexChanged += cbStudent_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID";
            // 
            // studentName
            // 
            studentName.Location = new Point(105, 95);
            studentName.Name = "studentName";
            studentName.Size = new Size(113, 27);
            studentName.TabIndex = 3;
            studentName.TextChanged += studentName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(301, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // dobTime
            // 
            dobTime.AutoSize = true;
            dobTime.Location = new Point(251, 51);
            dobTime.Name = "dobTime";
            dobTime.Size = new Size(40, 20);
            dobTime.TabIndex = 8;
            dobTime.Text = "DOB";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(251, 102);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(63, 24);
            maleRadioButton.TabIndex = 9;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(350, 102);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 24);
            femaleRadioButton.TabIndex = 10;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(femaleRadioButton);
            Controls.Add(maleRadioButton);
            Controls.Add(dobTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(studentName);
            Controls.Add(label1);
            Controls.Add(cbStudent);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbStudent;
        private Label label1;
        private TextBox studentName;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label dobTime;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
    }
}