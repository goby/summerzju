using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewSummerProject.MyDataOperate;
using ESRI.ArcGIS.Geodatabase;

namespace NewSummerProject.MyForms
{
    public partial class DbConnForm : Form
    {
        private GeoDB mSDEConn;

        public DbConnForm()
        {
            InitializeComponent();
        }

        private void btnDBConnNext_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (checkBox1.Checked)
                mSDEConn = new GeoDB(txtConnName.Text, "sde:sqlserver:" + txtDBServer.Text,
                    txtDBName.Text, "dbo.DEFAULT");
            else
                mSDEConn = new GeoDB(txtConnName.Text, "sde:sqlserver:" + txtDBServer.Text,
                    txtDBUserName.Text, txtDBUserPwd.Text, txtDBName.Text, "dbo.DEFAULT");
            mSDEConn.SdeConnect();

            if (mSDEConn.WorkSpace != null)
            {
                MessageBox.Show("连接成功" + mSDEConn.WorkSpace.PathName);
                GetDataNames(mSDEConn.WorkSpace, ref list);
                //AddToListView(list);
                //StepDisplay(2);
            }

        }

        private void btnStep2Next_Click(object sender, EventArgs e)
        {

        }

        private void GetDataNames(IWorkspace pWs, ref List<string> sList)
        {
            IEnumDataset peDt = pWs.get_Datasets(esriDatasetType.esriDTAny);
            peDt.Reset();
            IDataset pDt;
            while ((pDt = peDt.Next()) != null)
            {
                if (pDt.Type == esriDatasetType.esriDTFeatureDataset)
                {
                    IFeatureWorkspace pFw = (IFeatureWorkspace)pWs;
                    IFeatureDataset pFdt = pFw.OpenFeatureDataset(pDt.Name);
                    IEnumDataset peDt2 = pFdt.Subsets;
                    IDataset pDt2;
                    string test = "";
                    while ((pDt2 = peDt2.Next()) != null)
                    {
                        test += pDt2.Name + "\n";
                    }
                    MessageBox.Show(test);
                }
                else if (pDt.Type == esriDatasetType.esriDTFeatureClass)
                {
                    if (pDt.Name != "")
                    {
                        sList.Add(pDt.Name);
                    }
                }
                else if (pDt.Type == esriDatasetType.esriDTRasterDataset)
                {
                    if (pDt.Name != "")
                    {
                        sList.Add(pDt.Name);
                    }
                }
                else
                {
                    if (pDt.Name != "")
                    {
                        sList.Add(pDt.Name);
                    }
                }
            }
        }

        private void DbConnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                e.Cancel = true;
        }

    }
}
