﻿namespace GeoDo.RSS.MIF.Prds.LST
{
    partial class UCAnlysisTool
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInfos = new System.Windows.Forms.RichTextBox();
            this.txtIdenfiy = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件附加信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInfos);
            this.panel1.Controls.Add(this.txtIdenfiy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 316);
            this.panel1.TabIndex = 2;
            // 
            // txtInfos
            // 
            this.txtInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfos.Location = new System.Drawing.Point(5, 30);
            this.txtInfos.Name = "txtInfos";
            this.txtInfos.Size = new System.Drawing.Size(298, 279);
            this.txtInfos.TabIndex = 7;
            this.txtInfos.Text = "";
            // 
            // txtIdenfiy
            // 
            this.txtIdenfiy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdenfiy.Location = new System.Drawing.Point(86, 3);
            this.txtIdenfiy.Name = "txtIdenfiy";
            this.txtIdenfiy.Size = new System.Drawing.Size(218, 21);
            this.txtIdenfiy.TabIndex = 2;
            this.txtIdenfiy.Text = "地表温度";
            // 
            // UCAnlysisTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCAnlysisTool";
            this.Size = new System.Drawing.Size(308, 316);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtIdenfiy;
        public System.Windows.Forms.RichTextBox txtInfos;
    }
}
