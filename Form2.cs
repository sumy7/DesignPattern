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
                string path = Application.StartupPath;
                string strpath = path + @"/datebase.mdb";
                string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strpath;
                OleDbConnection olecon = new OleDbConnection(constr);
                olecon.Open();
                //OleDbCommand oledcom = new OleDbCommand("insert into dezignpattern(UML) values(@ImageList)", olecon);
                OleDbCommand oledcom = new OleDbCommand("update dezignpattern set UML=@ImageList where Name='"+richTextBox1.Text+"'", olecon);
                oledcom.Parameters.Add("ImageList", OleDbType.Binary);
                oledcom.Parameters["ImageList"].Value = imagebytes;
                oledcom.ExecuteNonQuery();
                olecon.Close();
                MessageBox.Show("图片保存完毕");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //更新简介
            string path = Application.StartupPath;
            string strpath = path + @"/datebase.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strpath;
            OleDbConnection olecon = new OleDbConnection(constr);
            olecon.Open();
            //OleDbCommand oledcom = new OleDbCommand("insert into dezignpattern(UML) values(@ImageList)", olecon);
            OleDbCommand oledcom = new OleDbCommand("update dezignpattern set Summer='"+richTextBox2.Text+"' where Name='" + richTextBox1.Text + "'", olecon);
            oledcom.ExecuteNonQuery();
            olecon.Close();
            MessageBox.Show("简介更新完毕");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //更新总结
            string path = Application.StartupPath;
            string strpath = path + @"/datebase.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strpath;
            OleDbConnection olecon = new OleDbConnection(constr);
            olecon.Open();
            //OleDbCommand oledcom = new OleDbCommand("insert into dezignpattern(UML) values(@ImageList)", olecon);
            OleDbCommand oledcom = new OleDbCommand("update dezignpattern set MainText='" + richTextBox2.Text + "' where Name='" + richTextBox1.Text + "'", olecon);
            oledcom.ExecuteNonQuery();
            olecon.Close();
            MessageBox.Show("总结更新完毕");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //更新代码
            string path = Application.StartupPath;
            string strpath = path + @"/datebase.mdb";
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strpath;
            OleDbConnection olecon = new OleDbConnection(constr);
            olecon.Open();
            //OleDbCommand oledcom = new OleDbCommand("insert into dezignpattern(UML) values(@ImageList)", olecon);
            OleDbCommand oledcom = new OleDbCommand("update dezignpattern set Code='" + richTextBox2.Text + "' where Name='" + richTextBox1.Text + "'", olecon);
            oledcom.ExecuteNonQuery();
            olecon.Close();
            MessageBox.Show("代码更新完毕");
        }
    }
}
