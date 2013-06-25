using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace DesignPattern
{
    /// <summary>
    /// condb 的摘要说明
    /// </summary>
    public class AccessDBHelper
    {
        private OleDbConnection conn;
        private static AccessDBHelper _Instance;
        private OleDbDataAdapter oda = new OleDbDataAdapter();
        private OleDbCommand cmd;
        private DataSet myds = new DataSet();
        private AccessDBHelper()
        {
            string DatabaseLocation = Application.StartupPath + @"\datebase.mdb";
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DatabaseLocation);
                conn.Open();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("未找到数据库，请检查数据库位置。\n期望：" + DatabaseLocation+"\n异常信息："+e.ToString());
                Application.Exit();
            }
        }
        public static AccessDBHelper getInstance()
        {
            if (_Instance == null)
            {
                _Instance = new AccessDBHelper();
            }
            return (_Instance);
        }
        public DataSet getDS(string strSQL)
        {
            myds = new DataSet();
            oda = new OleDbDataAdapter(strSQL, conn);
            oda.Fill(myds);
            return myds;
        }

        public DataSet getDS2(string strSQL, int si, int mi)
        {
            conn.Open();
            myds = new DataSet();
            oda = new OleDbDataAdapter(strSQL, conn);
            oda.Fill(myds, si, mi, "tab1");
            conn.Close();
            return myds;

        }

        public bool setDS(string strSQL)
        {
            conn.Open();
            cmd = new OleDbCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
