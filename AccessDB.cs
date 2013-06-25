using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Data;

namespace DesignPattern
{
    class AccessDB:connDatebase
    {
        AccessDBHelper db= AccessDBHelper.getInstance();
        DataSet ResultSet;
        public AccessDB(string Location) { }
        public AccessDB() { }
        public override void execQuery(string name)
        {
            try
            {
                ResultSet = db.getDS(@"select * from dezignpattern where Name='" + name + @"'");
            }
            catch (Exception e)
            {
                Debug.WriteLine("获取数据库数据异常。" + e.ToString());
            }
        }
        public override string getSummer()
        {
            string Result = "";
            try
            {
                Result = ResultSet.Tables[0].Rows[0]["Summer"].ToString();
            }
            catch (Exception)
            { }
            return Result;
        }
        public override string getText()
        {
            string Result = "";
            try
            {
                Result = ResultSet.Tables[0].Rows[0]["MainText"].ToString();
            }
            catch (Exception)
            { }
            return Result;
        }
        public override System.Drawing.Image getUML()
        {
            byte[] imageBytes = null;
            try
            {
                imageBytes = (byte[])ResultSet.Tables[0].Rows[0]["UML"];
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception)
            { }
            finally
            { }
            return null;
        }
        public override List< KeyValuePair<string,int> > getLevel()
        {
            List< KeyValuePair<string,int> > Result = new List< KeyValuePair<string,int> >();
            try
            {
                DataSet myset = db.getDS(@"select * from mainindex where 1=1");
                foreach (DataRow row in myset.Tables[0].Rows)
                {
                    Result.Add(new KeyValuePair<string,int>(row["Name"].ToString(),(int)row["Level"] ));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("获取列表异常" + e.ToString());
            }

            return Result;
        }
        public override string getCode()
        {
            string Result = "";
            try
            {
                Result = ResultSet.Tables[0].Rows[0]["exCode"].ToString();
            }
            catch (Exception)
            { }
            return Result;
        }
        public override bool ishasCode()
        {
            bool Result = false;
            try
            {
                Result = (bool)ResultSet.Tables[0].Rows[0]["HaveCode"];

            }
            catch (Exception)
            { }
            return Result;
        }
        public override bool ishasUML()
        {
            bool Result = false;
            try
            {
                Result = (bool)ResultSet.Tables[0].Rows[0]["HaveUML"];
            }
            catch (Exception)
            { }
            return Result;
        }
    }
}
