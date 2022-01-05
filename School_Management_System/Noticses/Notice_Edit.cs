using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Noticses
{
    public partial class Notice_Edit : Form
    {
        int noticeId;
        public Notice_Edit(int id)
        {
            InitializeComponent();
            noticeId = id;
        }
       
        
        private void Edit_subject_Load(object sender, EventArgs e)
        {
            
            MapSubjectEntries();

        }
        public void MapSubjectEntries()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getsubjectDetail = schoolManagementSystemEntities.subjects.Where(x => x.sub_id == subjectId).FirstOrDefault();
                if (getsubjectDetail != null)
                {
                    EditSubjectId.Text = getsubjectDetail.sub_id.ToString();
                    EditsubjectName.Text = getsubjectDetail.name_.ToString();
                    EditsubjectDesc.Text = getsubjectDetail.descripition.ToString();
                    EditsubjectAuth.Text = getsubjectDetail.author.ToString();
                    EditsubjectClassID.DataSource = classList;
                    EditsubjectClassID.DisplayMember = "name";
                    EditsubjectClassID.ValueMember = "class_id";
                    EditsubjectClassID.SelectedValue = getsubjectDetail.@class.class_id;
                }
            }
        }
        private void subjectAdd_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var editSubjectDetail = schoolManagementSystemEntities.subjects.Where(x => x.sub_id == subjectId).FirstOrDefault();
                if (editSubjectDetail != null)
                {
                    editSubjectDetail.sub_id = Convert.ToInt32(EditSubjectId.Text);
                    editSubjectDetail.name_ = EditsubjectName.Text;
                    editSubjectDetail.descripition = EditsubjectDesc.Text;
                    editSubjectDetail.author = EditsubjectAuth.Text;
                    editSubjectDetail.class_id = Convert.ToInt32(EditsubjectClassID.SelectedValue);

                    schoolManagementSystemEntities.Entry(editSubjectDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Update Successfully");
                    this.Close();

                }

            }
        }
        private void EditNotices_Click(object sender, EventArgs e)
        {

        }
    }
}
