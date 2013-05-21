using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DesignPattern
{

    public partial class frmMain : Form
    {
        String dbLocation = null;
        String path = null;
        connDatebase Datebase;
        public frmMain()
        {
            InitializeComponent();
        }
        private TreeNode treeListInit()
        {
            List< KeyValuePair<string,int> > nodelist = Datebase.getLevel();
            TreeNode[] node = new TreeNode[nodelist.Count()+1];
            node[0] = new TreeNode("设计模式");
            Debug.WriteLine("--" + nodelist.Count());
            //node[0].Text = "设计模式";
            for (int i = 1; i <= nodelist.Count(); i++)
            //for(int i=nodelist.Count();i>0;i--)
            {
                node[i] = new TreeNode(nodelist[i - 1].Key);
                Debug.WriteLine("--" + nodelist[i - 1].Key);
                node[nodelist[i - 1].Value].Nodes.Add(node[i]);
            }
            //now.Nodes.Add(node[0]);
            return node[0];
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
            dbLocation = path + @"/datebase.mdb";
            Datebase = new AccessDB(dbLocation);
            if (!Datebase.connection())
            {
                MessageBox.Show("未找到数据库，请检查数据库位置。\n期望："+dbLocation);
                Application.Exit();
            }
            //TreeNode node = new TreeNode("设计模式");
            treeView.Nodes.Add(treeListInit());
            //textSummer.Text = (string)Datebase.getSummer("简单工厂模式");
            //textMain.Text = (string)Datebase.getText("简单工厂模式");
            //picUML.Image = Datebase.getUML("简单工厂模式");
            textCode.CodeType = "cpp";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmtmp = new Form2();
            frmtmp.Show();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                //MessageBox.Show("选中了：" + treeView.SelectedNode.Text);
                textSummer.Text = (string)Datebase.getSummer(treeView.SelectedNode.Text);
                textMain.Text = (string)Datebase.getText(treeView.SelectedNode.Text);
                picUML.Image = Datebase.getUML(treeView.SelectedNode.Text);
                textCode.Text = Datebase.getCode(treeView.SelectedNode.Text);
            }
        }

        private void highLightTextbox1_Load(object sender, EventArgs e)
        {

        }
    }
}
