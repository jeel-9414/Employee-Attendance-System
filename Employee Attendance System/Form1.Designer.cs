namespace Employee_Attendance_System
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            printbtn = new Button();
            colorbtn = new Button();
            fontbtn = new Button();
            label11 = new Label();
            label5 = new Label();
            empidtxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            upbtn = new Button();
            savebtn = new Button();
            pictureBox1 = new PictureBox();
            salarytxt = new TextBox();
            deptcb = new ComboBox();
            empname = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            attid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            save1btn = new Button();
            groupBox1 = new GroupBox();
            abrb = new RadioButton();
            prerb = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            empcb = new ComboBox();
            tabPage3 = new TabPage();
            label15 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            groupBox2 = new GroupBox();
            abrb2 = new RadioButton();
            prrb2 = new RadioButton();
            save3btn = new Button();
            label13 = new Label();
            salary2txt = new TextBox();
            label12 = new Label();
            deptcb1 = new ComboBox();
            dispbtn = new Button();
            label10 = new Label();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            empcb2 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(41, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(874, 733);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(printbtn);
            tabPage1.Controls.Add(colorbtn);
            tabPage1.Controls.Add(fontbtn);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(empidtxt);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(upbtn);
            tabPage1.Controls.Add(savebtn);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(salarytxt);
            tabPage1.Controls.Add(deptcb);
            tabPage1.Controls.Add(empname);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(866, 700);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee Registration";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // printbtn
            // 
            printbtn.Location = new Point(331, 641);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(94, 29);
            printbtn.TabIndex = 17;
            printbtn.Text = "Print";
            printbtn.UseVisualStyleBackColor = true;
            //printbtn.Click += printbtn_Click;
            // 
            // colorbtn
            // 
            colorbtn.Location = new Point(594, 641);
            colorbtn.Name = "colorbtn";
            colorbtn.Size = new Size(94, 29);
            colorbtn.TabIndex = 16;
            colorbtn.Text = "Color";
            colorbtn.UseVisualStyleBackColor = true;
            //colorbtn.Click += colorbtn_Click;
            // 
            // fontbtn
            // 
            fontbtn.Location = new Point(594, 564);
            fontbtn.Name = "fontbtn";
            fontbtn.Size = new Size(94, 29);
            fontbtn.TabIndex = 15;
            fontbtn.Text = "Font";
            fontbtn.UseVisualStyleBackColor = true;
            fontbtn.Click += fontbtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 607);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 13;
            label11.Text = "label11";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 122);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 12;
            label5.Text = "Employee ID";
            // 
            // empidtxt
            // 
            empidtxt.Location = new Point(419, 115);
            empidtxt.Name = "empidtxt";
            empidtxt.Size = new Size(182, 27);
            empidtxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 390);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Photo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 303);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 239);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 179);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 7;
            label1.Text = "Employee Name";
            // 
            // upbtn
            // 
            upbtn.Location = new Point(419, 564);
            upbtn.Name = "upbtn";
            upbtn.Size = new Size(137, 29);
            upbtn.TabIndex = 6;
            upbtn.Text = "Upload Button";
            upbtn.UseVisualStyleBackColor = true;
            upbtn.Click += upbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(250, 564);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(94, 29);
            savebtn.TabIndex = 5;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(419, 368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 129);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // salarytxt
            // 
            salarytxt.Location = new Point(419, 300);
            salarytxt.Name = "salarytxt";
            salarytxt.Size = new Size(182, 27);
            salarytxt.TabIndex = 3;
            // 
            // deptcb
            // 
            deptcb.FormattingEnabled = true;
            deptcb.Location = new Point(419, 236);
            deptcb.Name = "deptcb";
            deptcb.Size = new Size(182, 28);
            deptcb.TabIndex = 2;
            // 
            // empname
            // 
            empname.Location = new Point(419, 172);
            empname.Name = "empname";
            empname.Size = new Size(182, 27);
            empname.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(138, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(579, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Employee Registration System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(attid);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(save1btn);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(empcb);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(866, 700);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Attendance tracker";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // attid
            // 
            attid.Location = new Point(411, 113);
            attid.Name = "attid";
            attid.Size = new Size(250, 27);
            attid.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(270, 119);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 9;
            label9.Text = "Attendance ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 367);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 7;
            label8.Text = "Attendance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 243);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 6;
            label7.Text = "Date ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 182);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 5;
            label6.Text = "Employee Name";
            label6.Click += label6_Click;
            // 
            // save1btn
            // 
            save1btn.Location = new Point(365, 496);
            save1btn.Name = "save1btn";
            save1btn.Size = new Size(94, 29);
            save1btn.TabIndex = 4;
            save1btn.Text = "Save";
            save1btn.UseVisualStyleBackColor = true;
            save1btn.Click += save1btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(abrb);
            groupBox1.Controls.Add(prerb);
            groupBox1.Location = new Point(411, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // abrb
            // 
            abrb.AutoSize = true;
            abrb.Location = new Point(234, 39);
            abrb.Name = "abrb";
            abrb.Size = new Size(76, 24);
            abrb.TabIndex = 1;
            abrb.TabStop = true;
            abrb.Text = "Absent";
            abrb.UseVisualStyleBackColor = true;
            // 
            // prerb
            // 
            prerb.AutoSize = true;
            prerb.Location = new Point(81, 39);
            prerb.Name = "prerb";
            prerb.Size = new Size(78, 24);
            prerb.TabIndex = 0;
            prerb.TabStop = true;
            prerb.Text = "Present";
            prerb.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(411, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(206, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(528, 47);
            textBox2.TabIndex = 1;
            textBox2.Text = "Attendance Tracker";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // empcb
            // 
            empcb.FormattingEnabled = true;
            empcb.Location = new Point(411, 174);
            empcb.Name = "empcb";
            empcb.Size = new Size(250, 28);
            empcb.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(dateTimePicker2);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(save3btn);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(salary2txt);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(deptcb1);
            tabPage3.Controls.Add(dispbtn);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(listBox1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(empcb2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(866, 700);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Emmployee Dashboard";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(114, 431);
            label15.Name = "label15";
            label15.Size = new Size(45, 20);
            label15.TabIndex = 17;
            label15.Text = "Date ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(207, 431);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(355, 336);
            label14.Name = "label14";
            label14.Size = new Size(85, 20);
            label14.TabIndex = 15;
            label14.Text = "Attendance";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(abrb2);
            groupBox2.Controls.Add(prrb2);
            groupBox2.Location = new Point(463, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 85);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // abrb2
            // 
            abrb2.AutoSize = true;
            abrb2.Location = new Point(234, 39);
            abrb2.Name = "abrb2";
            abrb2.Size = new Size(76, 24);
            abrb2.TabIndex = 1;
            abrb2.TabStop = true;
            abrb2.Text = "Absent";
            abrb2.UseVisualStyleBackColor = true;
            // 
            // prrb2
            // 
            prrb2.AutoSize = true;
            prrb2.Location = new Point(68, 37);
            prrb2.Name = "prrb2";
            prrb2.Size = new Size(78, 24);
            prrb2.TabIndex = 0;
            prrb2.TabStop = true;
            prrb2.Text = "Present";
            prrb2.UseVisualStyleBackColor = true;
            // 
            // save3btn
            // 
            save3btn.Location = new Point(159, 473);
            save3btn.Name = "save3btn";
            save3btn.Size = new Size(94, 29);
            save3btn.TabIndex = 13;
            save3btn.Text = "Save";
            save3btn.UseVisualStyleBackColor = true;
            save3btn.Click += save3btn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(517, 238);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 12;
            label13.Text = "Salary";
            // 
            // salary2txt
            // 
            salary2txt.Location = new Point(610, 231);
            salary2txt.Name = "salary2txt";
            salary2txt.Size = new Size(233, 27);
            salary2txt.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(517, 156);
            label12.Name = "label12";
            label12.Size = new Size(89, 20);
            label12.TabIndex = 10;
            label12.Text = "Department";
            // 
            // deptcb1
            // 
            deptcb1.FormattingEnabled = true;
            deptcb1.Location = new Point(610, 148);
            deptcb1.Name = "deptcb1";
            deptcb1.Size = new Size(233, 28);
            deptcb1.TabIndex = 9;
            // 
            // dispbtn
            // 
            dispbtn.Location = new Point(663, 473);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(94, 29);
            dispbtn.TabIndex = 8;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(114, 156);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 6;
            label10.Text = "Employee";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 449);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(860, 104);
            listBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 553);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(860, 144);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.Location = new Point(191, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(528, 47);
            textBox3.TabIndex = 2;
            textBox3.Text = "Employee Dashboard";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // empcb2
            // 
            empcb2.FormattingEnabled = true;
            empcb2.Location = new Point(207, 148);
            empcb2.Name = "empcb2";
            empcb2.Size = new Size(233, 28);
            empcb2.TabIndex = 0;
            empcb2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 838);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button upbtn;
        private Button savebtn;
        private PictureBox pictureBox1;
        private TextBox salarytxt;
        private ComboBox deptcb;
        private TextBox empname;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private TextBox empidtxt;
        private Label label8;
        private Label label6;
        private Button save1btn;
        private GroupBox groupBox1;
        private RadioButton abrb;
        private RadioButton prerb;
        private TextBox textBox2;
        private ComboBox empcb;
        private Label label9;
        private TextBox attid;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private ComboBox empcb2;
        private Label label10;
        private ListBox listBox1;
        private Button dispbtn;
        private Label label13;
        private TextBox salary2txt;
        private Label label12;
        private ComboBox deptcb1;
        private Button save3btn;
        private Label label14;
        private GroupBox groupBox2;
        private RadioButton abrb2;
        private RadioButton prrb2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private DateTimePicker dateTimePicker2;
        private OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;
        private Label label11;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Button fontbtn;
        private Button colorbtn;
        private Button printbtn;
    }
}
