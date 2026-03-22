using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Employee_Attendance_System
{
    public partial class Form1 : Form
    {
        string connect = "User Id=system;Password=it4;Data Source=localhost:1521;";
        string path = "";
        bool isEdit = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void department()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select * from department1";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                deptcb.DataSource = dt;
                deptcb.ValueMember = "dept_id";
                deptcb.DisplayMember = "dept_name";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void department1()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select * from department1";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                deptcb1.DataSource = dt;
                deptcb1.ValueMember = "dept_id";
                deptcb1.DisplayMember = "dept_name";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (empidtxt.Text == "" || empname.Text == "" || deptcb.SelectedValue == null || salarytxt.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("All Fields Are Mandatory!");
                return;
            }

            OracleConnection con = new OracleConnection(connect);
            int salary = Convert.ToInt32(salarytxt.Text);

            if (salary < 0)
            {
                MessageBox.Show("Salary Should be greater than 0");
                con.Close();
                return;
            }

            try
            {
                con.Open();

                string query = $@"Insert into employee1 values ('{empidtxt.Text}','{empname.Text}',{deptcb.SelectedValue},{salary},'{path}')";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            department();
            loadEmployee();
            loadEmployee1();
            department1();
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        public void loadEmployee()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select *  from employee1";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                empcb.DataSource = dt;
                empcb.ValueMember = "emp_id";
                empcb.DisplayMember = "emp_name";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void loadEmployee1()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = "Select *  from employee1";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                empcb2.DataSource = dt;
                empcb2.ValueMember = "emp_id";
                empcb2.DisplayMember = "emp_name";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void save1btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);

            string attendance = "";

            if (prerb.Checked)
            {
                attendance = prerb.Text;
            }
            else
            {
                attendance = abrb.Text;
            }

            try
            {
                con.Open();
                string query1 = $@"Select * from attendance where emp_id={empcb.SelectedValue} and att_id='{attid.Text}'";
                OracleCommand cmd1 = new OracleCommand(query1, con);
                OracleDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {
                    MessageBox.Show("Already Exist");
                    return;
                }
                string query = $@"Insert into Attendance values ('{attid.Text}',{empcb.SelectedValue},TO_DATE('{dateTimePicker1.Value:dd-MM-yyyy}','DD-MM-YYYY'),'{attendance}')";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public void loadData(int id)
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select e.emp_name,d.dept_name,d.location,e.salary from employee1 e,department1 d where d.dept_id=e.dept_id and e.emp_id={id}";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader dr = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (dr.Read())
                {
                    listBox1.Items.Add("Emaployee_Name:" + dr["emp_name"]);
                    listBox1.Items.Add("Department_Name:" + dr["dept_name"]);
                    listBox1.Items.Add("Location:" + dr["location"]);
                    listBox1.Items.Add("Salary:" + dr["salary"]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void display()
        {
            OracleConnection con = new OracleConnection(connect);

            try
            {
                con.Open();
                string query = $@"Select e.emp_id,d.dept_id,e.salary,a.status,a.att_date from Attendance a,employee1 e,department d where e.dept_id=d.dept_id and a.emp_id=e.emp_id";
                OracleCommand cmd = new OracleCommand(query, con);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (!dataGridView1.Columns.Contains("btnEdit"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Name = "btnEdit";
                    btn.Text = "Edit";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn);

                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    btn1.HeaderText = "Action";
                    btn1.Name = "btnDel";
                    btn1.Text = "Delete";
                    btn1.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn1);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dispbtn_Click(object sender, EventArgs e)
        {
            display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empcb2.SelectedValue == null) return;

            if (empcb2.SelectedValue is DataRowView) return;

            int id = Convert.ToInt32(empcb2.SelectedValue.ToString());
            loadData(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;


            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string attendance = row.Cells["status"].Value.ToString();

                if (attendance == "Present")
                {
                    prrb2.Checked = true;
                }
                else
                {
                    abrb.Checked = false;
                }

                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["att_date"].Value);
                empcb2.SelectedValue = row.Cells["emp_id"].Value;
                deptcb1.SelectedValue = row.Cells["dept_id"].Value;
                salary2txt.Text = row.Cells["Salary"].Value.ToString();

                isEdit = true;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if (MessageBox.Show("Are You Sure You Want to Delete?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleConnection con = new OracleConnection(connect);

                    try
                    {
                        con.Open();
                        string query = $@"Delete from attendance where emp_id={empcb2.SelectedValue}";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted!");
                        display();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void save3btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(connect);
            if (isEdit)
            {

                string attendance = "";
                if (prrb2.Checked)
                {
                    attendance = prrb2.Text;
                }
                else
                {
                    attendance = abrb2.Text;
                }
                try
                {
                    con.Open();
                    string query = $@"Update attendance set att_date=TO_DATE('{dateTimePicker2.Value:dd-MM-yyyy}','DD-MM-YYYY'),status='{attendance}' where emp_id={empcb2.SelectedValue}";
                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated!");
                    timer1.Start();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }

        private void fontbtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label11.Font = fontDialog1.Font;
            }

        }
    }
}
