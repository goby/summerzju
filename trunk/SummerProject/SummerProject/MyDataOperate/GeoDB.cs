using System;
using System.Collections.Generic;
using System.Text;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;

namespace NewSummerProject.MyDataOperate
{
    class GeoDB
    {
        private IWorkspace mWorkSpace = null;
        private IPropertySet mPropSet = new PropertySetClass();
        private Exception mError;

        /*
        private string sqlServer;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader ccmd;
        */

        private DataGrid dG = new DataGrid();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Server">服务器连接名称</param>
        /// <param name="Instance">ArcSDE实例"sde:sqlserver:computername\\sqlexpress"</param>
        /// <param name="User">用户名</param>
        /// <param name="Password">密码</param>
        /// <param name="Database">数据库名</param>
        /// <param name="version">ArcSDE版本("dbo.DEFAULT")</param>
        public GeoDB(string Server, string Instance, string User,string Password, string Database, string version)
		{
			mPropSet.SetProperty("SERVER", Server);
            mPropSet.SetProperty("INSTANCE", Instance);
            mPropSet.SetProperty("DATABASE", Database);
            mPropSet.SetProperty("USER", User);
            mPropSet.SetProperty("PASSWORD", Password);
            mPropSet.SetProperty("VERSION", version);
		}

        /// <summary>
        /// 以本地Windows管理员身份登录
        /// </summary>
        /// <param name="Server">服务器连接名称</param>
        /// <param name="Instance">ArcSDE实例"sde:sqlserver:computername\\sqlexpress"</param>
        /// <param name="Database">数据库名</param>
        /// <param name="version">ArcSDE版本("dbo.DEFAULT")</param>
        public GeoDB(string Server, string Instance, string Database, string version)
        {
            mPropSet.SetProperty("SERVER", Server);
            mPropSet.SetProperty("INSTANCE", Instance);
            mPropSet.SetProperty("DATABASE", Database);
            mPropSet.SetProperty("AUTHENTICATION_MODE", "OSA");
            mPropSet.SetProperty("VERSION", version);
        }

        public bool Connect()
        {
            bool connected = false;
            IWorkspaceFactory pSdeFact = new SdeWorkspaceFactoryClass();
            try
            {
                mWorkSpace = pSdeFact.Open(mPropSet, 0); 
                connected = true;
                mError = null;
            }
            catch (Exception e)
            {
                mError = e;
            }

            return connected;
        }

        public void SdeConnect()
        {
            if (!Connect())
                MessageBox.Show("错误：数据库连接失败！");
        }

        /// <summary>
        /// 打开的工作区
        /// </summary>
        public IWorkspace WorkSpace
        {
            get { return mWorkSpace; }     //_WorkSpace是私有的，所以用WorkSpace让外部程序可以访问它的值，不过似乎没有用到
        }

        /// <summary>
        /// 连接失败的错误信息
        /// </summary>
        public Exception Error
        {
            get { return mError; }
        }
    }
}
