using School_Management_System.Class;
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

namespace School_Management_System.Parent
{
    public partial class Edit_Parent : Form
    {
        int P_Id;
        public Edit_Parent(int ediParentId)
        {
            InitializeComponent();
            P_Id = ediParentId;
        }

        private void Edit_Parent_Load(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getParentDetail = schoolManagementSystemEntities.parents.Where(x => x.pr_id == P_Id).FirstOrDefault();
                if (getParentDetail != null)
                {
                    ParentId.Text = getParentDetail.pr_id.ToString();
                    parentName.Text = getParentDetail.name_.ToString();
                    parentEmail_txtbox.Text = getParentDetail.email.ToString();
                    parentCinc.Text = getParentDetail.cnic.ToString();
                    parentOccupation.Text = getParentDetail.occupation.ToString();
                    parentCellno.Text = getParentDetail.cell_no.ToString();
                    parentOffcno.Text = getParentDetail.office_no.ToString();
                    parentMonthlyInc.Text = getParentDetail.monthly_income.ToString();
                    parentStatus.Text = getParentDetail.status.ToString();

                }
            }
        }

        private void ParentEdit_Btn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var editParentDetail = schoolManagementSystemEntities.parents.Where(x => x.pr_id == P_Id).FirstOrDefault();
                if (editParentDetail != null)
                {
                    editParentDetail.pr_id = Convert.ToInt32(ParentId.Text);
                    editParentDetail.name_ = parentName.Text;
                    editParentDetail.email = parentEmail_txtbox.Text;
                    editParentDetail.cnic = parentCinc.Text;
                    editParentDetail.cell_no = parentCellno.Text;
                    editParentDetail.office_no = parentOffcno.Text;
                    if (editParentDetail.monthly_income != null)
                    {
                        editParentDetail.monthly_income = int.Parse(parentMonthlyInc.Text);
                    }
                    editParentDetail.status = parentStatus.Text;
                    schoolManagementSystemEntities.Entry(editParentDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Update Successfully");
                    this.Close();
                    Parent_Details cls = new Parent_Details();
                    cls.Activate();

                }

            }
        }
    }
}
