namespace DesignPattern
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outpanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picUML = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMain = new System.Windows.Forms.RichTextBox();
            this.buttons4 = new System.Windows.Forms.Button();
            this.buttons2 = new System.Windows.Forms.Button();
            this.buttons3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSummer = new System.Windows.Forms.RichTextBox();
            this.buttons1 = new System.Windows.Forms.Button();
            this.textCode = new DesignPattern.HighLightTextbox();
            this.outpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUML)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 45);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(221, 489);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "设计模式";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "开启上帝模式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outpanel
            // 
            this.outpanel.Controls.Add(this.panel4);
            this.outpanel.Controls.Add(this.panel3);
            this.outpanel.Controls.Add(this.panel2);
            this.outpanel.Controls.Add(this.buttons4);
            this.outpanel.Controls.Add(this.buttons2);
            this.outpanel.Controls.Add(this.buttons3);
            this.outpanel.Controls.Add(this.panel1);
            this.outpanel.Controls.Add(this.buttons1);
            this.outpanel.Location = new System.Drawing.Point(239, 45);
            this.outpanel.Name = "outpanel";
            this.outpanel.Size = new System.Drawing.Size(482, 489);
            this.outpanel.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picUML);
            this.panel4.Location = new System.Drawing.Point(374, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 148);
            this.panel4.TabIndex = 32;
            // 
            // picUML
            // 
            this.picUML.Location = new System.Drawing.Point(3, 3);
            this.picUML.Name = "picUML";
            this.picUML.Size = new System.Drawing.Size(88, 105);
            this.picUML.TabIndex = 7;
            this.picUML.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textCode);
            this.panel3.Location = new System.Drawing.Point(252, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 148);
            this.panel3.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textMain);
            this.panel2.Location = new System.Drawing.Point(363, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 111);
            this.panel2.TabIndex = 30;
            // 
            // textMain
            // 
            this.textMain.BackColor = System.Drawing.Color.White;
            this.textMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textMain.Location = new System.Drawing.Point(3, 3);
            this.textMain.Name = "textMain";
            this.textMain.ReadOnly = true;
            this.textMain.Size = new System.Drawing.Size(86, 94);
            this.textMain.TabIndex = 9;
            this.textMain.Text = "";
            // 
            // buttons4
            // 
            this.buttons4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttons4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttons4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons4.Location = new System.Drawing.Point(173, 7);
            this.buttons4.Name = "buttons4";
            this.buttons4.Size = new System.Drawing.Size(48, 486);
            this.buttons4.TabIndex = 29;
            this.buttons4.Text = "UML\r\n框\r\n图";
            this.buttons4.UseVisualStyleBackColor = false;
            this.buttons4.Click += new System.EventHandler(this.buttons4_Click);
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttons2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttons2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons2.Location = new System.Drawing.Point(65, 7);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(48, 486);
            this.buttons2.TabIndex = 26;
            this.buttons2.Text = "模\r\n式\r\n说\r\n明";
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttons3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttons3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons3.Location = new System.Drawing.Point(119, 7);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(48, 486);
            this.buttons3.TabIndex = 27;
            this.buttons3.Text = "示\r\n例\r\n代\r\n码";
            this.buttons3.UseVisualStyleBackColor = false;
            this.buttons3.Click += new System.EventHandler(this.buttons3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textSummer);
            this.panel1.Location = new System.Drawing.Point(252, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 108);
            this.panel1.TabIndex = 25;
            // 
            // textSummer
            // 
            this.textSummer.BackColor = System.Drawing.Color.White;
            this.textSummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSummer.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSummer.ForeColor = System.Drawing.Color.Black;
            this.textSummer.Location = new System.Drawing.Point(3, 8);
            this.textSummer.Name = "textSummer";
            this.textSummer.ReadOnly = true;
            this.textSummer.Size = new System.Drawing.Size(91, 86);
            this.textSummer.TabIndex = 5;
            this.textSummer.Text = "";
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttons1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttons1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttons1.Location = new System.Drawing.Point(11, 7);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(48, 486);
            this.buttons1.TabIndex = 28;
            this.buttons1.Text = "简\r\n介";
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // textCode
            // 
            this.textCode.CodeType = null;
            this.textCode.Location = new System.Drawing.Point(5, 16);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(91, 116);
            this.textCode.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.outpanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmMain";
            this.Text = "设计模式";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.outpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUML)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel outpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picUML;
        private System.Windows.Forms.Panel panel3;
        private HighLightTextbox textCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textMain;
        private System.Windows.Forms.Button buttons4;
        private System.Windows.Forms.Button buttons2;
        private System.Windows.Forms.Button buttons3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textSummer;
        private System.Windows.Forms.Button buttons1;
    }
}

