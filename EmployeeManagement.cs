using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace EmployeePromact1
{
    public partial class Employee : Form
    {

        public object EmployeeEdit { get; private set; }

        public Employee()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=P841609-W10N\SQLEXPRESS;Initial Catalog=Employee_Management;Integrated Security=True");
        public int DepartmentId;
        public int EmployeeId;
  

        void clearData()
        {
            DepartmentId = 0;
            EmployeeId = 0;
            DeptNametxt.Text = DeptAbrtxt.Text = DeptDesctxt.Text = "";
            EmpNametxt.Text = EmpSurnametxt.Text = EmpQualificationtxt.Text = EmpAddresstxt.Text = EmpContact.Text = EmpDeptcombo.DisplayMember = "";
            
            DeptNametxt.Focus();
            EmpNametxt.Focus();
        }

        private bool IsValidDepartment()
        { 
           if(DeptNametxt.Text ==String.Empty)
            {
                MessageBox.Show("Deparment Name is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
             }
            return true;
        }

        private bool IsValidEmployee()
        {
            if (EmpNametxt.Text == String.Empty && EmpSurnametxt.Text == String.Empty && EmpDeptcombo.DisplayMember == String.Empty)
            {
                MessageBox.Show("Employee name and Surname required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ShowDepartmentDetails()
        {
            SqlCommand cmdshow = new SqlCommand("Select * from Departments", con);
            DataTable dtshow1 = new DataTable();
           con.Open();

            SqlDataReader sdrshow1 = cmdshow.ExecuteReader();

            dtshow1.Load(sdrshow1);
            con.Close();

            dgvDepartment.DataSource = dtshow1;

        }

        private void ShowEmployeeDetails()
        {
            SqlCommand cmdshow = new SqlCommand("Select * from Employees", con);
            DataTable dtshow2 = new DataTable();
            con.Open();

            SqlDataReader sdrshow2 = cmdshow.ExecuteReader();

            dtshow2.Load(sdrshow2);
           con.Close();

            dgvEmployeegrid.DataSource = dtshow2;

        }


        private void comboboxshow()
        {
           con.Open();
            SqlCommand cmdcomboshow = new SqlCommand("Select * from Departments", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdcomboshow);
            DataTable dtshow3 = new DataTable();

            sda.Fill(dtshow3);
          

            DataRow dr1 = dtshow3.NewRow();
            dr1.ItemArray = new object[] { 0, "--Select Department--" };
            dtshow3.Rows.InsertAt(dr1, 0);
            EmpDeptcombo.ValueMember = "id";
            EmpDeptcombo.DisplayMember = "Department_Name";
            con.Close();
            EmpDeptcombo.DataSource = dtshow3;

        }


        private void AddDept_Click(object sender, EventArgs e)
        {
            if (IsValidDepartment())
            {
                SqlCommand cmdInsert = con.CreateCommand();
                cmdInsert.CommandText = "Execute InsertDepartment @Department_Name,@Abbreviations,@Dept_Description";

                cmdInsert.Parameters.Add("@Department_Name", SqlDbType.VarChar, 50).Value = DeptNametxt.Text.ToString();
                cmdInsert.Parameters.Add("@Abbreviations", SqlDbType.VarChar, 50).Value = DeptAbrtxt.Text.ToString();
                cmdInsert.Parameters.Add("@Dept_Description", SqlDbType.VarChar, 150).Value = DeptDesctxt.Text.ToString();
               con.Open();

                cmdInsert.ExecuteNonQuery();
               con.Close();

                MessageBox.Show("Department added Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

                ShowDepartmentDetails();
                clearData();
                comboboxshow();


            }
        }
        private void UpdateDept_Click(object sender, EventArgs e)
        {
            if (DepartmentId > 0)
            {

                SqlCommand cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "Execute UpdateDepartment @Department_ID,@Department_Name,@Abbreviations,@Dept_Description";

                cmdUpdate.Parameters.Add("@Department_Name", SqlDbType.VarChar, 50).Value = DeptNametxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Abbreviations", SqlDbType.VarChar, 50).Value = DeptAbrtxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Dept_Description", SqlDbType.VarChar, 150).Value = DeptDesctxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Department_ID", SqlDbType.Int).Value = DepartmentId;
               con.Open();

                cmdUpdate.ExecuteNonQuery();
              con.Close();

                MessageBox.Show("Department info Update Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowEmployeeDetails();
                clearData();
                comboboxshow();

            }

            else
            {
                MessageBox.Show("Select Department to update", "SELECTED?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DelDept(object sender, EventArgs e)
        {
            if (DepartmentId > 0)
            {
                SqlCommand cmddel = con.CreateCommand();
                cmddel.CommandText = "Execute DeleteDepartment @Department_ID";
                cmddel.Parameters.Add("@Department_ID", SqlDbType.Int).Value = DepartmentId;
                con.Open();

                cmddel.ExecuteNonQuery();
               con.Close();

                MessageBox.Show("Department Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowDepartmentDetails();
                clearData();
                comboboxshow();
            }
            else
            {
                MessageBox.Show("Select department to Delete", "SELECTED?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DepartmentId = Convert.ToInt32(dgvDepartment.Rows[0].Cells[0].Value);
            DeptNametxt.Text = dgvDepartment.SelectedRows[0].Cells[1].Value.ToString();
            DeptAbrtxt.Text = dgvDepartment.SelectedRows[0].Cells[2].Value.ToString();
            DeptDesctxt.Text = dgvDepartment.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (IsValidEmployee())
            {
                SqlCommand cmdInsert = con.CreateCommand();
                cmdInsert.CommandText = "Execute InsertEmployees @Emp_Name,@Emp_Surname,@Emp_Qualification,@Emp_Address,@Emp_ContactNum,@Emp_department";

                cmdInsert.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = EmpNametxt.Text.ToString();
                cmdInsert.Parameters.Add("@Emp_Surname", SqlDbType.VarChar, 15).Value = EmpSurnametxt.Text.ToString();
                cmdInsert.Parameters.Add("@Emp_Qualification", SqlDbType.VarChar, 30).Value = EmpQualificationtxt.Text.ToString();
                cmdInsert.Parameters.Add("@Emp_Address", SqlDbType.VarChar, 100).Value = EmpAddresstxt.Text.ToString();
                cmdInsert.Parameters.Add("@Emp_ContactNum", SqlDbType.VarChar, 30).Value = EmpContact.Text.ToString();
                cmdInsert.Parameters.Add("@Emp_department", SqlDbType.VarChar, 50).Value = EmpDeptcombo.DisplayMember.ToString();

                con.Open();

                cmdInsert.ExecuteNonQuery();
               con.Close();

                MessageBox.Show("Employee added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowEmployeeDetails();
                clearData();
            }
        }

        private void DelEmpBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeId > 0)
            {
                SqlCommand cmddel = con.CreateCommand();
                cmddel.CommandText = "Execute DeleteEmployee @Emp_ID";
                cmddel.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = EmployeeId;
              con.Open();

                cmddel.ExecuteNonQuery();
             con.Close();

                MessageBox.Show("Employee Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowEmployeeDetails();
                clearData();
            }
            else
            {
                MessageBox.Show("Select Employee to Delete", "SELECTED?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditEmpbtn_Click(object sender, EventArgs e)
        {
            EmployeeEdit E2 = new EmployeeEdit(this);
            E2.Show();

           // EmployeeId = Convert.ToInt32(dgvEmployeegrid.Rows[0].Cells[0].Value);
           // EmpNametxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[1].Value.ToString();
           // EmpSurnametxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[1].Value.ToString();
           // EmpQualificationtxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[3].Value.ToString();
           // EmpAddresstxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[4].Value.ToString();
           //EmpContact.Text = dgvEmployeegrid.SelectedRows[0].Cells[5].Value.ToString();
           // EmpDeptcombo.DisplayMember = dgvEmployeegrid.SelectedRows[0].Cells[6].Value.ToString();

        }


        private void dgvEmployeegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeEdit E2 = new EmployeeEdit(this);
            E2.Show();

            EmployeeId = Convert.ToInt32(dgvEmployeegrid.Rows[0].Cells[0].Value);
            EmpNametxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[1].Value.ToString();
            EmpSurnametxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[1].Value.ToString();
            EmpQualificationtxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[3].Value.ToString();
            EmpAddresstxt.Text = dgvEmployeegrid.SelectedRows[0].Cells[4].Value.ToString();
            EmpContact.Text = dgvEmployeegrid.SelectedRows[0].Cells[5].Value.ToString();
            EmpDeptcombo.DisplayMember = dgvEmployeegrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void ResetEmpBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

      

        private void Employee_Load(object sender, EventArgs e)
        {
            ShowDepartmentDetails();
            ShowEmployeeDetails();
            comboboxshow();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearData();
        }

     
    }
   }

