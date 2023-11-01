namespace Project
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            studentName = new TextBox();
            label2 = new Label();
            lab1 = new TextBox();
            label3 = new Label();
            assignment = new TextBox();
            label4 = new Label();
            pe = new TextBox();
            label5 = new Label();
            fe = new TextBox();
            label6 = new Label();
            update = new Button();
            exit = new Button();
            systemMenu = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            cbClass = new ComboBox();
            label7 = new Label();
            lab2 = new TextBox();
            label8 = new Label();
            cbStudentid = new ComboBox();
            label9 = new Label();
            textBoxSubject = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            importButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(650, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 103);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID";
            // 
            // studentName
            // 
            studentName.Location = new Point(156, 189);
            studentName.Name = "studentName";
            studentName.Size = new Size(125, 27);
            studentName.TabIndex = 3;
            studentName.TextChanged += studentName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 196);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Student Name";
            // 
            // lab1
            // 
            lab1.Location = new Point(156, 233);
            lab1.Name = "lab1";
            lab1.Size = new Size(125, 27);
            lab1.TabIndex = 5;
            lab1.TextChanged += lab1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 236);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "Lab 1";
            // 
            // assignment
            // 
            assignment.Location = new Point(156, 334);
            assignment.Name = "assignment";
            assignment.Size = new Size(125, 27);
            assignment.TabIndex = 7;
            assignment.TextChanged += assignment_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 337);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Assignment";
            label4.Click += label4_Click;
            // 
            // pe
            // 
            pe.Location = new Point(156, 435);
            pe.Name = "pe";
            pe.Size = new Size(125, 27);
            pe.TabIndex = 9;
            pe.TextChanged += pe_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 442);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 10;
            label5.Text = "Practical Exam";
            // 
            // fe
            // 
            fe.Location = new Point(156, 381);
            fe.Name = "fe";
            fe.Size = new Size(125, 27);
            fe.TabIndex = 11;
            fe.TextChanged += fe_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 388);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 12;
            label6.Text = "Theory Exam";
            // 
            // update
            // 
            update.Location = new Point(87, 479);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 14;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // exit
            // 
            exit.Location = new Point(631, 479);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 16;
            exit.Text = "EXIT";
            exit.UseVisualStyleBackColor = true;
            // 
            // systemMenu
            // 
            systemMenu.ImageScalingSize = new Size(20, 20);
            systemMenu.Name = "System";
            systemMenu.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 28);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(31, 24);
            aToolStripMenuItem.Text = "a";
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(156, 58);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(125, 28);
            cbClass.TabIndex = 18;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 58);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 19;
            label7.Text = "Class";
            // 
            // lab2
            // 
            lab2.Location = new Point(156, 282);
            lab2.Name = "lab2";
            lab2.Size = new Size(125, 27);
            lab2.TabIndex = 20;
            lab2.TextChanged += lab2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 285);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 21;
            label8.Text = "Lab 2";
            // 
            // cbStudentid
            // 
            cbStudentid.FormattingEnabled = true;
            cbStudentid.Location = new Point(156, 103);
            cbStudentid.Name = "cbStudentid";
            cbStudentid.Size = new Size(125, 28);
            cbStudentid.TabIndex = 22;
            cbStudentid.SelectedIndexChanged += cbStudentid_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 152);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 24;
            label9.Text = "Subject";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(156, 149);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(125, 27);
            textBoxSubject.TabIndex = 25;
            textBoxSubject.TextChanged += textBoxSubject_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // importButton
            // 
            importButton.Location = new Point(217, 479);
            importButton.Name = "importButton";
            importButton.Size = new Size(94, 29);
            importButton.TabIndex = 26;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 520);
            Controls.Add(importButton);
            Controls.Add(textBoxSubject);
            Controls.Add(label9);
            Controls.Add(cbStudentid);
            Controls.Add(label8);
            Controls.Add(lab2);
            Controls.Add(label7);
            Controls.Add(cbClass);
            Controls.Add(menuStrip1);
            Controls.Add(exit);
            Controls.Add(update);
            Controls.Add(label6);
            Controls.Add(fe);
            Controls.Add(label5);
            Controls.Add(pe);
            Controls.Add(label4);
            Controls.Add(assignment);
            Controls.Add(label3);
            Controls.Add(lab1);
            Controls.Add(label2);
            Controls.Add(studentName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox studentName;
        private Label label2;
        private TextBox lab1;
        private Label label3;
        private TextBox assignment;
        private Label label4;
        private TextBox pe;
        private Label label5;
        private TextBox fe;
        private Label label6;
        private Button update;
        private Button exit;
        private ContextMenuStrip systemMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ComboBox cbClass;
        private Label label7;
        private TextBox lab2;
        private Label label8;
        private ComboBox cbStudentid;
        private Label label9;
        private TextBox textBoxSubject;
        private OpenFileDialog openFileDialog1;
        private Button importButton;
    }
}