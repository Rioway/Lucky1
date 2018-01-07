namespace Lucky
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lucky.Properties.Resources.timg1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 359);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("华文中宋", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(211, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "【喜气洋洋抽奖系统】";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPerson
            // 
            this.btnPerson.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnPerson.FlatAppearance.BorderSize = 2;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPerson.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnPerson.Location = new System.Drawing.Point(185, 223);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(107, 97);
            this.btnPerson.TabIndex = 2;
            this.btnPerson.Text = "抽奖名单";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSetting.FlatAppearance.BorderSize = 2;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSetting.Location = new System.Drawing.Point(304, 223);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(107, 97);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "奖项设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnStart.Location = new System.Drawing.Point(423, 223);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 97);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始抽奖";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnPresent.FlatAppearance.BorderSize = 2;
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPresent.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnPresent.Location = new System.Drawing.Point(542, 223);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(107, 97);
            this.btnPresent.TabIndex = 2;
            this.btnPresent.Text = "中奖名单";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnClose.Location = new System.Drawing.Point(627, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(674, 369);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnClose;
    }
}

