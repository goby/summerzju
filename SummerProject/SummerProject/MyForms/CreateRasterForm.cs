using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace SummerProject.MyForms
{
    public partial class CreateRasterForm : Form
    {
        private IFeatureClass mFeatureClass = null;
        private IMap mIMap;

        public IMap Map
        {
            get { return mIMap; }
            set { mIMap = value; }
        }

        public CreateRasterForm()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }

        private void OnLoadFeatureClass(object sender, EventArgs e)
        {
            IGxDialog iGxDlg = new GxDialogClass();
            iGxDlg.Title = "选择点数据集";
            iGxDlg.ObjectFilter = new GxFilterPointFeatureClassesClass();
            IEnumGxObject selection;
            iGxDlg.DoModalOpen(0, out selection);
            selection.Reset();

            IGxObject iGxObject;
            while ((iGxObject = selection.Next()) != null)
            {
                IGxDataset iGxDataset = (IGxDataset)iGxObject;
                if (iGxDataset != null)
                {
                    IDataset iDataset = iGxDataset.Dataset;
                    IFeatureClass iFc = (IFeatureClass)iDataset;
                    mFeatureClass = iFc;

                    textBox6.Text = iGxObject.FullName;

                    //设置ComboBox
                    comboBox1.ResetText();
                    IFields iFields = iFc.Fields;
                    long iCount = iFields.FieldCount;
                    for (int i = 0; i < iCount; i++)
                    {
                        IField iField = iFields.get_Field(i);
                        comboBox1.Items.Add(iField.Name);
                    }

                    if (comboBox1.Items.Count > 0)
                        comboBox1.SelectedIndex = 0;
                }
            }
        }//Open Feature Class

        private void IDWOperate(IFeatureClass inFC)
        {
            IFeatureClassDescriptor iFCDesc = new FeatureClassDescriptorClass();
            //获取选中的字符串
            string sFieldName = comboBox1.SelectedText;
            iFCDesc.Create(inFC, null, sFieldName);
            //创建RasterInterpolationOp对象
            IInterpolationOp iIo = new RasterInterpolationOpClass();

            //设置输出Raster网格大小，默认的Raster输出空间范围和输入数据相同
            IRasterAnalysisEnvironment iRae = (IRasterAnalysisEnvironment)iIo;
            object oCellSize = (object)Convert.ToDouble(textBox2.Text);
            iRae.SetCellSize(esriRasterEnvSettingEnum.esriRasterEnvValue, ref oCellSize);
           
            //搜索范围设置
            IRasterRadius iRadius = new RasterRadiusClass();
            //switch (comboBox2.SelectedIndex)
            //{
            //    case 0:
                    object dis = (object)Convert.ToDouble(textBox3.Text);
                    iRadius.SetVariable(Convert.ToInt32(textBox1.Text), ref dis);
            //        break;
            //    case 1:
            //        object cou = (object)Convert.ToDouble(textBox3.Text);
            //        iRadius.SetFixed(Convert.ToDouble(textBox1.Text), ref cou);
            //        break;
            //    default:
            //        break;
            //}

            IGeoDataset iInputGeo = (IGeoDataset)iFCDesc;
            object barrier = Type.Missing;
            IGeoDataset iOutputGeo = iIo.IDW(iInputGeo, Convert.ToDouble(textBox2.Text), iRadius, ref barrier);

            IRaster iOutRaster = (IRaster)iOutputGeo;
            IRasterBandCollection iRasBnadC = (IRasterBandCollection)iOutRaster;
            IWorkspaceFactory iWSF = new RasterWorkspaceFactoryClass();
            IWorkspace iWS = iWSF.OpenFromFile(textBox5.Text, 0);

            IDataset iDs = iRasBnadC.SaveAs("Raster_test", iWS, "GRID");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //progressBar1.Increment(20);
            IDWOperate(mFeatureClass);
            //progressBar1.Increment(50);
            IFeatureLayer iFLayer = new FeatureLayerClass();
            iFLayer.FeatureClass = mFeatureClass;
            //mIMap.AddLayer(iFLayer);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            button1.Enabled = true;
            //IActiveView iAV = (IActiveView)mIMap;
            //iAV.Refresh();
        }

        //确认
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            button1.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        //搜索范围类型ComboBox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label4.Text = "点的数目：";
                label5.Text = "最大距离：";
                textBox1.Text = "12";
                textBox3.Text = "";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label4.Text = "距离：";
                label5.Text = "最小数目：";
                textBox1.Text = "";
                textBox3.Text = "0";
            }
        }

        //取消按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                if (MessageBox.Show("确认取消？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    backgroundWorker1.CancelAsync();
            }
            else
            {
                if (MessageBox.Show("确认退出？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    this.Close();
            }
        }

    }
}
