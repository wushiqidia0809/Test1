namespace test1
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.textboxop1 = new System.Windows.Forms.TextBox();
            this.textboxop2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonadd.Font = new System.Drawing.Font("宋体", 26F);
            this.buttonadd.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonadd.Location = new System.Drawing.Point(281, 147);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(137, 113);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textboxop1
            // 
            this.textboxop1.Font = new System.Drawing.Font("宋体", 16F);
            this.textboxop1.Location = new System.Drawing.Point(119, 161);
            this.textboxop1.Name = "textboxop1";
            this.textboxop1.Size = new System.Drawing.Size(100, 44);
            this.textboxop1.TabIndex = 1;
            // 
            // textboxop2
            // 
            this.textboxop2.Font = new System.Drawing.Font("宋体", 16F);
            this.textboxop2.Location = new System.Drawing.Point(119, 232);
            this.textboxop2.Name = "textboxop2";
            this.textboxop2.Size = new System.Drawing.Size(100, 44);
            this.textboxop2.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 24F);
            this.labelResult.Location = new System.Drawing.Point(116, 69);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(164, 48);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 317);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textboxop2);
            this.Controls.Add(this.textboxop1);
            this.Controls.Add(this.buttonadd);
            this.Name = "Form1";
            this.Text = "My Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textboxop1;
        private System.Windows.Forms.TextBox textboxop2;
        private System.Windows.Forms.Label labelResult;
    }
}

