﻿namespace ControlDemo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cicleImageView1 = new wanjia.Controls.CicleImageView();
            this.SuspendLayout();
            // 
            // cicleImageView1
            // 
            this.cicleImageView1.BackColor = System.Drawing.Color.Transparent;
            this.cicleImageView1.Image = global::ControlDemo.Properties.Resources._1780106_jpg;
            this.cicleImageView1.Location = new System.Drawing.Point(12, 12);
            this.cicleImageView1.Name = "cicleImageView1";
            this.cicleImageView1.Size = new System.Drawing.Size(229, 214);
            this.cicleImageView1.TabIndex = 0;
            this.cicleImageView1.Text = "cicleImageView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cicleImageView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private wanjia.Controls.CicleImageView cicleImageView1;
    }
}

