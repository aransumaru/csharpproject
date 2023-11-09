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
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            button2 = new Button();
            studentidText = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(786, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(158, 43);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(113, 28);
            cbStudent.TabIndex = 1;
            cbStudent.SelectedIndexChanged += cbStudent_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID";
            // 
            // studentName
            // 
            studentName.Location = new Point(102, 73);
            studentName.Name = "studentName";
            studentName.Size = new Size(113, 27);
            studentName.TabIndex = 3;
            studentName.TextChanged += studentName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(302, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // dobTime
            // 
            dobTime.AutoSize = true;
            dobTime.Location = new Point(252, 28);
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
            maleRadioButton.Location = new Point(316, 78);
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
            femaleRadioButton.Location = new Point(415, 78);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 24);
            femaleRadioButton.TabIndex = 10;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(573, 24);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(676, 24);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 12;
            editButton.Text = "Edit/Save";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(573, 73);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(676, 73);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // studentidText
            // 
            studentidText.Location = new Point(102, 28);
            studentidText.Name = "studentidText";
            studentidText.Size = new Size(113, 27);
            studentidText.TabIndex = 17;
            studentidText.TextChanged += studentidText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 43);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 18;
            label4.Text = "Choose Student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(studentidText);
            groupBox1.Controls.Add(studentName);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dobTime);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(maleRadioButton);
            groupBox1.Controls.Add(editButton);
            groupBox1.Controls.Add(femaleRadioButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 125);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data input";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(cbStudent);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button button2;
        private TextBox studentidText;
        private Label label4;
        private GroupBox groupBox1;
    }
}