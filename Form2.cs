using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace DesignPattern
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.jpg|*.gif|*.gif|*.BMP|*.BMP";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullpath = openFileDialog1.FileName;
                FileStream fs = new FileStream(fullpath, FileMode.Open);
                byte[] imagebytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imagebytes = br.ReadBytes(Convert.ToInt32(fs.Length));
                //string strpath = Application.StartupPath + "\\a.xls";
                //string strpath = Application.StartupPath + "\\b.mdb";
                string strpath = "c:\\datebase.mdb";
                string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strpath;
                OleDbConnection olecon = new OleDbConnection(constr);
                olecon.Open();
                //OleDbCommand oledcom = new OleDbCommand("insert into dezignpattern(UML) values(@ImageList)", olecon);
                OleDbCommand oledcom = new OleDbCommand("update dezignpattern set UML=@ImageList where Name='简单工厂模式'", olecon);
                oledcom.Parameters.Add("ImageList", OleDbType.Binary);
                oledcom.Parameters["ImageList"].Value = imagebytes;
                oledcom.ExecuteNonQuery();
                olecon.Close();
                MessageBox.Show("图片保存完毕");
            }
        }
    }
}
