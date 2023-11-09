namespace Project
{
    partial class ClassManagement
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
            cbClass = new ComboBox();
            cbSubject = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            removeButton = new Button();
            dataGridView2 = new DataGridView();
            studentNameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1118, 229);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(105, 31);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(151, 28);
            cbClass.TabIndex = 1;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(416, 31);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(151, 28);
            cbSubject.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Class";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 33);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Subject";
            // 
            // addButton
            // 
            addButton.Location = new Point(1012, 24);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(1012, 72);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(94, 29);
            removeButton.TabIndex = 6;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1, 456);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1118, 229);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // studentNameText
            // 
            studentNameText.Location = new Point(630, 32);
            studentNameText.Name = "studentNameText";
            studentNameText.Size = new Size(125, 27);
            studentNameText.TabIndex = 8;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 683);
            Controls.Add(studentNameText);
            Controls.Add(dataGridView2);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSubject);
            Controls.Add(cbClass);
            Controls.Add(dataGridView1);
            Name = "ClassManagement";
            Text = "ClassManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbClass;
        private ComboBox cbSubject;
        private Label label1;
        private Label label2;
        private Button addButton;
        private Button removeButton;
        private DataGridView dataGridView2;
        private TextBox studentNameText;
    }
}