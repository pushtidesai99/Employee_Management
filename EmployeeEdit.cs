using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePromact1
{
    public partial class EmployeeEdit : Form
    {
        Employee E1;
        public EmployeeEdit(Employee Emp1)
        {
            InitializeComponent();
            this.E1 = Emp1;
        }

        public EmployeeEdit()
        {
        }

        SqlConnection con = new SqlConnection(@"Data Source=P841609-W10N\SQLEXPRESS;Initial Catalog=Employee_Management;Integrated Security=True");

       
        public int EmployeeId;
       


        public void UpdateEmp_Click(object sender, EventArgs e)
        {
            EmployeeId = 0;
            if (EmployeeId > 0)
            {

                SqlCommand cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "Execute UpdateDepartment @Emp_ID,@Emp_Name,@Emp_Surname,@Emp_Qualification,@Emp_Address,@Emp_ContactNum,@Emp_department";

                cmdUpdate.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = EmployeeId;
                cmdUpdate.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = editempNametxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Emp_Surname", SqlDbType.VarChar, 15).Value = EditEmpSurnametxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Emp_Qualification", SqlDbType.VarChar, 30).Value = EditEmpQualtxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Emp_Address", SqlDbType.VarChar, 100).Value = EditEmpAddtxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Emp_ContactNum", SqlDbType.VarChar, 30).Value = EditEmpContxt.Text.ToString();
                cmdUpdate.Parameters.Add("@Emp_department", SqlDbType.VarChar, 50).Value = editEmpdeptcombo.DisplayMember.ToString();
                con.Open();

                cmdUpdate.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee Data info Update Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Select Employee to update", "SELECTED?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelEmp_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            editempNametxt.Text = E1.EmpNametxt.Text;
            EditEmpSurnametxt.Text = E1.EmpSurnametxt.Text;
            EditEmpQualtxt.Text = E1.EmpQualificationtxt.Text;
            EditEmpAddtxt.Text = E1.EmpContact.Text;
            EditEmpContxt.Text = E1.EmpContact.Text;
            editEmpdeptcombo.DisplayMember = E1.EmpDeptcombo.DisplayMember;

               
        }

        private void DelEmpBtn_Click(object sender, EventArgs e)
        {
       
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

                }
                else
                {
                    MessageBox.Show("Select Employee to Delete", "SELECTED?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
