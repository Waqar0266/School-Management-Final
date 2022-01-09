using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Salary
{
    public partial class Edit_Salary : Form
    {
        int salaryId;
        public Edit_Salary(int id)
        {
            InitializeComponent();
            salaryId = id;
        }
        private void Edit_Salary_Load(object sender, EventArgs e)
        {
            GetAllEmpInfo();
            MapSubjectEntries();
            
        }


        public void MapSubjectEntries()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getSalaryDetail = schoolManagementSystemEntities.salaries.Where(x => x.sal_id == salaryId).FirstOrDefault();
                if (getSalaryDetail != null)
                {
                    EditSalaryEmpID.Text = getSalaryDetail.teacher.name_.ToString();
                    EditSalaryEmpID.DisplayMember = getSalaryDetail.teacher.name_.ToString();
                    //EditSalaryEmpID.ValueMember = getSalaryDetail.teacher.t_id.ToString();
                    EditSalaryMonth.Text = getSalaryDetail.month_.ToString();
                    EditsalaryIssueDate.Text = getSalaryDetail.issue_date.ToString();
                    EditSalaryBasic.Text = getSalaryDetail.basic_sal.ToString();
                    EditSalaryDedcution.Text = getSalaryDetail.deduction.ToString();
                    EditSalaryAllowances.Text = getSalaryDetail.allowances.ToString();
                    EditSalaryAdvance.Text = getSalaryDetail.advance_sal.ToString();
                    EditSalaryTotal.Text = getSalaryDetail.total_amount.ToString();
                }
            }
        }
        public void GetAllEmpInfo()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var empDetails = schoolManagementSystemEntities.teachers.ToList();
                if (empDetails.Count() > 0)
                {
                    EditSalaryEmpID.DataSource = empDetails;
                    EditSalaryEmpID.DisplayMember = "name_";
                    EditSalaryEmpID.ValueMember = "t_id";

                }
            }
        }

        private void EditSave_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var editSalaryDetail = schoolManagementSystemEntities.salaries.Where(x => x.sal_id == salaryId).FirstOrDefault();
                if (editSalaryDetail != null)
                {
                    editSalaryDetail.t_id = Convert.ToInt32(EditSalaryEmpID.SelectedValue);
                    editSalaryDetail.month_= EditSalaryMonth.Text;
                    editSalaryDetail.issue_date=EditsalaryIssueDate.Value;
                    int x = 0;
                    if (Int32.TryParse(EditSalaryBasic.Text, out x))
                    {
                        editSalaryDetail.basic_sal = x;
                    }
                    if (Int32.TryParse(EditSalaryDedcution.Text, out x))
                    {
                        editSalaryDetail.deduction = x;
                    }
                    if (Int32.TryParse(EditSalaryAllowances.Text, out x))
                    {
                        editSalaryDetail.allowances = x;
                    }
                    if (Int32.TryParse(EditSalaryAdvance.Text, out x))
                    {
                        editSalaryDetail.advance_sal = x;
                    }
                    if (Int32.TryParse(EditSalaryTotal.Text, out x))
                    {
                        editSalaryDetail.total_amount = x;
                    }

                    //editSalaryDetail.basic_sal= Convert.ToInt32(EditSalaryBasic.Text);
                    // editSalaryDetail.deduction=Convert.ToInt32(EditSalaryDedcution.Text);
                    //editSalaryDetail.allowances= Convert.ToInt32(EditSalaryAllowances.Text);
                    //editSalaryDetail.advance_sal= Convert.ToInt32(EditSalaryAdvance.Text );
                    //editSalaryDetail.total_amount= Convert.ToInt32(EditSalaryTotal.Text) ;


                    schoolManagementSystemEntities.Entry(editSalaryDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Update Successfully");
                    this.Close();

                }
            }
        }
        private void EditSalaryEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var empid = EditSalaryEmpID.Text;
                var getEmpDetail = schoolManagementSystemEntities.teachers.Where(x => x.name_ == empid).FirstOrDefault();
                if (getEmpDetail != null)
                {

                    EditempNameText.Text = getEmpDetail.name_.ToString();
                    EditempCnicText.Text = getEmpDetail.cnic.ToString();
                    EditempDesgnText.Text = getEmpDetail.subject.ToString();

                }
            }
        }
    }
}
