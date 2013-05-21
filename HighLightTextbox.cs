using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace DesignPattern
{
    public partial class HighLightTextbox : UserControl
    {
        public void showLineNo()
        {
            //获得当前坐标信息
            Point p = this.richTextBox1.Location;
            int crntFirstIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int crntFirstLine = this.richTextBox1.GetLineFromCharIndex(crntFirstIndex);
            Point crntFirstPos = this.richTextBox1.GetPositionFromCharIndex(crntFirstIndex);
            //
            p.Y += this.richTextBox1.Height;
            //
            int crntLastIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int crntLastLine = this.richTextBox1.GetLineFromCharIndex(crntLastIndex);
            Point crntLastPos = this.richTextBox1.GetPositionFromCharIndex(crntLastIndex);
            //
            //
            //准备画图
            Graphics g = this.panel1.CreateGraphics();
            Font font = new Font(this.richTextBox1.Font, this.richTextBox1.Font.Style);
            SolidBrush brush = new SolidBrush(Color.Green);
            //
            //
            //画图开始
            //刷新画布
            Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel1.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            brush.Color = Color.Green;//重置画笔颜色
            //
            //绘制行号
            int lineSpace = 0;
            if (crntFirstLine != crntLastLine)
            {
                lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            }
            else
            {
                lineSpace = Convert.ToInt32(this.richTextBox1.Font.Size);
            }
            int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);//惊人的算法啊！！
            for (int i = crntLastLine; i >= crntFirstLine; i--)
            {
                g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }
        public HighLightTextbox()
        {
            InitializeComponent();
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Height = this.Height;
            richTextBox1.Left = panel1.Width;
            richTextBox1.Top = 0;
            richTextBox1.Height = this.Height;
            richTextBox1.Width = this.Width - panel1.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            showLineNo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            //HighLightText();
        }

        private void HighLightTextbox_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.WordWrap = false;
        }
        private void richTextBox1_HScorll(object sender, EventArgs e)
        {

        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            showLineNo();
        }  

    }
}
