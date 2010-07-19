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
        private ConnectionStep steps;

        public DbConnForm()
        {
            InitializeComponent();
            this.Size = new Size(335, 355);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StepFlow(1);
        }

        private void btnDBConnNext_Click(object sender, EventArgs e)
        {
            
            steps = ConnectionStep.ConnectDatabase;

            backgroundWorker1.RunWorkerAsync(steps);
            this.btnDBConnNext.Enabled = false;
            this.progressBar1.Value = 0;
            int i = 0;
            while (backgroundWorker1.IsBusy)
            {
                progressBar1.Increment(1);
                //if (progressBar1.Value > 98)
                //    progressBar1.Value = 0;
                Application.DoEvents();
            }

        }
        
        //添加信息到listView1
        private void AddToListView(List<string> list)
        {
            listView1.Clear();

            //ListView初始化
            listView1.Columns.Add("",22);
            listView1.Columns.Add("字段名", this.listView1.Width - 26);

            foreach (string item in list)
            {
                if (item != "")
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(item);
                    listView1.Items.Add(lvi);
                }

            }
        }//End of Method: AddToListView

        private void btnStep2Next_Click(object sender, EventArgs e)
        {

        }//End of Button Event : btnStep2 Click

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
        }//End of Method: GetDataNames

        private void FirstStep()
        {
            List<string> list = new List<string>();

            if (checkOSA.Checked)
                mSDEConn = new GeoDB(txtConnName.Text, "sde:sqlserver:" + txtDBServer.Text,
                    txtDBName.Text, "dbo.DEFAULT");
            else
                mSDEConn = new GeoDB(txtConnName.Text, "sde:sqlserver:" + txtDBServer.Text,
                    txtDBUserName.Text, txtDBUserPwd.Text, txtDBName.Text, "dbo.DEFAULT");
            mSDEConn.SdeConnect();

            if (mSDEConn.WorkSpace != null)
            {
                GetDataNames(mSDEConn.WorkSpace, ref list);
                AddToListView(list);
                MessageBox.Show("连接成功" + mSDEConn.WorkSpace.PathName);
            }
        }

        private void DbConnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason != CloseReason.FormOwnerClosing)
            //   e.Cancel = true;
        }//End of Form Event: this Closing

        private void checkOSA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOSA.Checked)
            {
                label1.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                txtDBUserName.Enabled = false;
                txtDBUserPwd.Enabled = false;
            }
            else
            {
                label1.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                txtDBUserName.Enabled = true;
                txtDBUserPwd.Enabled = true;
            }
        }//End of CheckBox Event: Check Changed

        private void StepFlow(int step)
        {
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            switch (step)
            {
                case 1:
                    this.panel1.Visible = true;
                    this.panel1.Location = new System.Drawing.Point(0, 0);
                    this.btnDBConnPre.Enabled = false;
                    break;
                case 2:
                    this.panel2.Visible = true;
                    this.panel2.Location = new System.Drawing.Point(0, 0);
                    break;
            }
        }//End of Method: StepFlow

        private void btnStep2Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close(); 
        }

        //使用BackgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectionStep step = (ConnectionStep)e.Argument;
            switch (step)
            {
                case ConnectionStep.ConnectDatabase:
                    FirstStep();
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.btnDBConnNext.Enabled = true;
            progressBar1.Value = 100;
            StepFlow(2);
        }

        private void btnDBConnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                if (MessageBox.Show("是否取消连接？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    backgroundWorker1.CancelAsync();
                    this.btnDBConnCancel.Enabled = true;
                }
            }
            else
                if (MessageBox.Show("是否退出？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    this.Close();
            
        }
    }

    internal enum ConnectionStep 
    {
        ConnectDatabase,
        SelectDatabase,
        LoadData
    }
}
