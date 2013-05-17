using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace DesignPattern
{
    class AccessDB:connDatebase
    {
        private string dbLocation = "";
        private string dbKey = "";
        private string strConnection = "Provider=Microsoft.Jet.OleDb.4.0;";
        private OleDbConnection objConnection;
        public AccessDB(string Location)
        {
            strConnection = @"Provider=Microsoft.Jet.OleDb.4.0;";
            dbLocation = Location; 
            dbKey = "";
            strConnection += (@"Data Source="+dbLocation); 
        }
/*        public AccessDB(string Location, string Key)
        {
            dbLocation = Location;
            dbKey = Key;
        }
*/
        public override bool connection()
        {
            objConnection = new OleDbConnection(strConnection);  //建立连接   
            //测试连接
            try
            {
                objConnection.Open();
                objConnection.Close();
                objConnection.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine("存在异常："+e.ToString());
                return false;
                
            }
            return true;
        }
        public override bool disConnection()
        {
            objConnection.Close();
            return true;
        }
        public override string getSummer(string name)
        {
            string Result = "";
            OleDbCommand sqlcmd = null;
            OleDbDataReader reader=null;
            try
            {
                //objConnection.Open();  //打开连接  
                sqlcmd = new OleDbCommand(@"select * from dezignpattern where Name='" + name + @"'", objConnection);  //sql语句
                reader = sqlcmd.ExecuteReader();              //执行查询   
                if (reader.Read())
                { //这个read调用很重要！不写的话运行时将提示找不到数据   
                    Result = (string)reader["Summer"];   //取得字段的值   
                }
                Debug.WriteLine("--总结：" + Result);
                reader.Close();
                //objConnection.Close();
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("获取总结异常：" + e.ToString());
            }
            finally
            {

            }
            return Result;
        }
        public override string getText(string name)
        {
            string Result = "";
            try
            {
                //objConnection.Open();  //打开连接  
                OleDbCommand sqlcmd = new OleDbCommand(@"select * from dezignpattern where Name='" + name + @"'", objConnection);  //sql语句
                OleDbDataReader reader = sqlcmd.ExecuteReader();              //执行查询   
                if (reader.Read())
                { //这个read调用很重要！不写的话运行时将提示找不到数据   
                    Result = (string)reader["MainText"];   //取得字段的值   

                }
                //objConnection.Close();
                reader.Close();
                Debug.WriteLine("--" + Result);
            }
            catch (Exception e) { }
            
            return Result;
        }
        public override System.Drawing.Image getUML(string name)
        {            
            try
            {
                //objConnection.Open();  //打开连接  
                OleDbCommand sqlcmd = new OleDbCommand(@"select * from dezignpattern where Name='" + name + @"'", objConnection);  //sql语句
                OleDbDataReader reader = sqlcmd.ExecuteReader();              //执行查询   
                byte[] imageBytes = null;
                if (reader.Read())
                { //这个read调用很重要！不写的话运行时将提示找不到数据   
                    imageBytes = (byte[])reader["UML"];   //取得字段的值   
                }
                //objConnection.Close();
                reader.Close();
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception e) { }
            return null;    
        }
        public override List< KeyValuePair<string,int> > getLevel()
        {
            List< KeyValuePair<string,int> > Result = new List< KeyValuePair<string,int> >();
            OleDbCommand sqlcmd =null;
            OleDbDataReader reader=null;
            try
            {
                string sql = @"select * from mainindex where 1=1";
                //objConnection.Open();  //打开连接  
                sqlcmd = new OleDbCommand(sql, objConnection); ;   //sql语句
                reader = sqlcmd.ExecuteReader();              //执行查询   
                while (reader.Read())
                { //这个read调用很重要！不写的话运行时将提示找不到数据   
                    Result.Add(new KeyValuePair<string, int>((string)reader["Name"], (int)reader["Level"]));   //取得字段的值   
                    Debug.WriteLine("shujuku" + reader["Name"] + reader["Level"]);
                }
                Debug.WriteLine("shujuku" + Result.Count);
                reader.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("异常" + e.ToString());
            }
            finally
            {
                //objConnection.Close();
                
            }
            return Result;
        }
        public override string getCode(string name)
        {
            string Result = "";
            OleDbCommand sqlcmd = null;
            OleDbDataReader reader = null;
            try
            {
                //objConnection.Open();  //打开连接  
                sqlcmd = new OleDbCommand(@"select * from dezignpattern where Name='" + name + @"'", objConnection);  //sql语句
                reader = sqlcmd.ExecuteReader();              //执行查询   
                if (reader.Read())
                { //这个read调用很重要！不写的话运行时将提示找不到数据   
                    Result = (string)reader["Code"];   //取得字段的值   
                }
                Debug.WriteLine("--Code：" + Result);
                reader.Close();
                //objConnection.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine("获取代码异常：" + e.ToString());
            }
            finally
            {

            }
            return Result;
        }
    }
}
