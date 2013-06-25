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
        private int slideBarCode = 0;
        DatabaseFactory DataFactory = new AccessDBFactory();
        connDatebase Database;
        public frmMain()
        {
            Database = DataFactory.getFactory();
            InitializeComponent();
            freshFrm();
        }
        private TreeNode treeListInit()
        {
            List<KeyValuePair<string, int>> nodelist = Database.getLevel();
            TreeNode[] node = new TreeNode[nodelist.Count() + 1];
            node[0] = new TreeNode("设计模式");
            for (int i = 1; i <= nodelist.Count(); i++)
            {
                node[i] = new TreeNode(nodelist[i - 1].Key);
                node[nodelist[i - 1].Value].Nodes.Add(node[i]);
            }
            return node[0];
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Database = new AccessDB("");
            treeView.Nodes.Add(treeListInit());
            treeView.TopNode.ExpandAll();
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
                Database.execQuery(treeView.SelectedNode.Text);
                textSummer.Text = (string)Database.getSummer();
                textMain.Text = (string)Database.getText();
                picUML.Image = Database.getUML();
                textCode.Text = Database.getCode();
            }
        }

        private void textCode_Load(object sender, EventArgs e)
        {

        }

        private void freshFrm()
        {
            const int pad=20;

            button1.Top = this.Height - button1.Height - 2*pad;
            treeView.Height = button1.Top - treeView.Top ;

            outpanel.Left = treeView.Left + treeView.Width;
            outpanel.Top = treeView.Top;
            outpanel.Width = this.Width - outpanel.Left-pad;
            outpanel.Height = treeView.Height;

            buttons1.Left = 0;
            buttons1.Top = 0;
            buttons1.Height = outpanel.Height;
            buttons2.Left = buttons1.Left + buttons1.Width;
            buttons2.Top = 0;
            buttons2.Height = outpanel.Height;
            buttons3.Left = buttons2.Left + buttons2.Width;
            buttons3.Top = 0;
            buttons3.Height = outpanel.Height;
            buttons4.Left = buttons3.Left + buttons3.Width;
            buttons4.Top = 0;
            buttons4.Height = outpanel.Height;

            switch (slideBarCode)
            {
                case 0: showpanel1(); break;
                case 1: showpanel2(); break;
                case 2: showpanel3(); break;
                case 3: showpanel4(); break;
                default: break;
            }
        }
        private void showpanel1()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            buttons1.Left = 0;
            buttons1.Top = 0;
            buttons1.Height = outpanel.Height;
            buttons4.Left = outpanel.Width-buttons4.Width;
            buttons4.Top = 0;
            buttons4.Height = outpanel.Height;
            buttons3.Left = buttons4.Left - buttons3.Width;
            buttons3.Top = 0;
            buttons3.Height = outpanel.Height;
            buttons2.Left = buttons3.Left - buttons2.Width;
            buttons2.Top = 0;
            buttons2.Height = outpanel.Height;

            panel1.Left = buttons1.Left + buttons1.Width;
            panel1.Top = 0;
            panel1.Width = outpanel.Width - 4 * buttons1.Width;
            panel1.Height = outpanel.Height;

            textSummer.Top = 0;
            textSummer.Left = 0;
            textSummer.Width = panel1.Width;
            textSummer.Height = panel1.Height;
        }
        private void showpanel2()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            buttons1.Left = 0;
            buttons1.Top = 0;
            buttons1.Height = outpanel.Height;
            buttons2.Left = buttons1.Left + buttons1.Width;
            buttons2.Top = 0;
            buttons2.Height = outpanel.Height;
            buttons4.Left = outpanel.Width - buttons4.Width;
            buttons4.Top = 0;
            buttons4.Height = outpanel.Height;
            buttons3.Left = buttons4.Left - buttons3.Width;
            buttons3.Top = 0;
            buttons3.Height = outpanel.Height;

            panel2.Left = buttons2.Left + buttons2.Width;
            panel2.Top = 0;
            panel2.Width = outpanel.Width - 4 * buttons1.Width;
            panel2.Height = outpanel.Height;

            textMain.Top = 0;
            textMain.Left = 0;
            textMain.Width = panel2.Width;
            textMain.Height = panel2.Height;
        }
        private void showpanel3()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            buttons1.Left = 0;
            buttons1.Top = 0;
            buttons1.Height = outpanel.Height;
            buttons2.Left = buttons1.Left + buttons1.Width;
            buttons2.Top = 0;
            buttons2.Height = outpanel.Height;
            buttons3.Left = buttons2.Left + buttons2.Width;
            buttons3.Top = 0;
            buttons3.Height = outpanel.Height;
            buttons4.Left = outpanel.Width - buttons4.Width;
            buttons4.Top = 0;
            buttons4.Height = outpanel.Height;

            panel3.Left = buttons3.Left + buttons3.Width;
            panel3.Top = 0;
            panel3.Width = outpanel.Width - 4 * buttons1.Width;
            panel3.Height = outpanel.Height;

            textCode.Top = 0;
            textCode.Left = 0;
            textCode.Width = panel3.Width;
            textCode.Height = panel3.Height;
        }
        private void showpanel4()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

            buttons1.Left = 0;
            buttons1.Top = 0;
            buttons1.Height = outpanel.Height;
            buttons2.Left = buttons1.Left + buttons1.Width;
            buttons2.Top = 0;
            buttons2.Height = outpanel.Height;
            buttons3.Left = buttons2.Left + buttons2.Width;
            buttons3.Top = 0;
            buttons3.Height = outpanel.Height;
            buttons4.Left = buttons3.Left + buttons3.Width;
            buttons4.Top = 0;
            buttons4.Height = outpanel.Height;

            panel4.Left = buttons4.Left + buttons4.Width;
            panel4.Top = 0;
            panel4.Width = outpanel.Width - 4 * buttons1.Width;
            panel4.Height = outpanel.Height;

            picUML.Top = 0;
            picUML.Left = 0;
            picUML.Width = panel4.Width;
            picUML.Height = panel4.Height;
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            showpanel1();
            slideBarCode = 0;
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            showpanel2();
            slideBarCode = 1;
        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            showpanel3();
            slideBarCode = 2;
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            showpanel4();
            slideBarCode = 3;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            freshFrm();
        }

    }
}
