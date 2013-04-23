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
            this.label2 = new System.Windows.Forms.Label();
            this.textSummer = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picUML = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMain = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.highLightTextbox1 = new DesignPattern.HighLightTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.picUML)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(262, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "简介";
            // 
            // textSummer
            // 
            this.textSummer.BackColor = System.Drawing.Color.White;
            this.textSummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSummer.ForeColor = System.Drawing.Color.Black;
            this.textSummer.Location = new System.Drawing.Point(264, 45);
            this.textSummer.Name = "textSummer";
            this.textSummer.ReadOnly = true;
            this.textSummer.Size = new System.Drawing.Size(511, 52);
            this.textSummer.TabIndex = 4;
            this.textSummer.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "UML框图";
            // 
            // picUML
            // 
            this.picUML.Location = new System.Drawing.Point(264, 136);
            this.picUML.Name = "picUML";
            this.picUML.Size = new System.Drawing.Size(510, 178);
            this.picUML.TabIndex = 6;
            this.picUML.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(262, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "模式说明";
            // 
            // textMain
            // 
            this.textMain.BackColor = System.Drawing.Color.White;
            this.textMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMain.Location = new System.Drawing.Point(264, 356);
            this.textMain.Name = "textMain";
            this.textMain.ReadOnly = true;
            this.textMain.Size = new System.Drawing.Size(511, 178);
            this.textMain.TabIndex = 8;
            this.textMain.Text = "";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1004, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(796, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "示例代码";
            // 
            // highLightTextbox1
            // 
            this.highLightTextbox1.Location = new System.Drawing.Point(798, 48);
            this.highLightTextbox1.Name = "highLightTextbox1";
            this.highLightTextbox1.Size = new System.Drawing.Size(547, 521);
            this.highLightTextbox1.TabIndex = 11;
            this.highLightTextbox1.Load += new System.EventHandler(this.highLightTextbox1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 584);
            this.Controls.Add(this.highLightTextbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picUML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmMain";
            this.Text = "设计模式";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textSummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picUML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private HighLightTextbox highLightTextbox1;
    }
}

