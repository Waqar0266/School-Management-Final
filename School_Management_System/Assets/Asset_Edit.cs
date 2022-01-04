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

namespace School_Management_System.Assets
{
    public partial class Asset_Edit : Form
    {
        int assetEditId;
        public Asset_Edit(int id)
        {
            InitializeComponent();
            assetEditId = id;
        }

        private void EditAssetsBtn_Click(object sender, EventArgs e)
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var editAssetDetail = schoolManagementSystemEntities.assets.Where(x => x.as_id == assetEditId).FirstOrDefault();
                if (editAssetDetail != null)
                {
                    editAssetDetail.type_ = EditAssetType.Text;
                    editAssetDetail.name_ = EditAssetName.Text;
                    editAssetDetail.descripition = EditAssetDescription.Text;
                    editAssetDetail.amount = Convert.ToInt32(EditAssetAmount.Text);
                    editAssetDetail.date_ = EditAssetDate.Value;
                    schoolManagementSystemEntities.Entry(editAssetDetail).State = EntityState.Modified;
                    schoolManagementSystemEntities.SaveChanges();
                    MessageBox.Show("Record Update Successfully");
                    this.Close();

                }

            }
        }
        public void MapAssetEntries()
        {
            using (SchoolManagementSystemEntities schoolManagementSystemEntities = new SchoolManagementSystemEntities())
            {
                var getassetDetail = schoolManagementSystemEntities.assets.Where(x => x.as_id == assetEditId).FirstOrDefault();
                if (getassetDetail != null)
                {
                    EditAssetType.Text = getassetDetail.type_.ToString();
                    EditAssetName.Text = getassetDetail.name_.ToString();
                    EditAssetDate.Text = getassetDetail.date_.ToString();
                    EditAssetDescription.Text = getassetDetail.descripition.ToString();
                    EditAssetAmount.Text = getassetDetail.amount.ToString();
                }
            }
        }
        private void Asset_Edit_Load(object sender, EventArgs e)
            {
                MapAssetEntries();
            }

           
        }
    }
