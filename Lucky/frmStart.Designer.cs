namespace Lucky
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurrentLevel = new System.Windows.Forms.Label();
            this.lbLuckyPerson = new System.Windows.Forms.Label();
            this.btnStartorStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lboxLuckyPerson = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("华文宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(23, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 39);
            this.lbTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "现在抽：";
            // 
            // lbCurrentLevel
            // 
            this.lbCurrentLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentLevel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCurrentLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCurrentLevel.Location = new System.Drawing.Point(51, 126);
            this.lbCurrentLevel.Name = "lbCurrentLevel";
            this.lbCurrentLevel.Size = new System.Drawing.Size(447, 55);
            this.lbCurrentLevel.TabIndex = 1;
            this.lbCurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLuckyPerson
            // 
            this.lbLuckyPerson.BackColor = System.Drawing.Color.Blue;
            this.lbLuckyPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLuckyPerson.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLuckyPerson.ForeColor = System.Drawing.Color.Magenta;
            this.lbLuckyPerson.Location = new System.Drawing.Point(103, 294);
            this.lbLuckyPerson.Name = "lbLuckyPerson";
            this.lbLuckyPerson.Size = new System.Drawing.Size(313, 58);
            this.lbLuckyPerson.TabIndex = 1;
            this.lbLuckyPerson.Text = "李扬威 18202749697";
            this.lbLuckyPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartorStop
            // 
            this.btnStartorStop.BackColor = System.Drawing.Color.Red;
            this.btnStartorStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartorStop.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartorStop.ForeColor = System.Drawing.Color.Yellow;
            this.btnStartorStop.Location = new System.Drawing.Point(180, 210);
            this.btnStartorStop.Name = "btnStartorStop";
            this.btnStartorStop.Size = new System.Drawing.Size(147, 65);
            this.btnStartorStop.TabIndex = 0;
            this.btnStartorStop.Text = "开    始";
            this.btnStartorStop.UseVisualStyleBackColor = false;
            this.btnStartorStop.Click += new System.EventHandler(this.btnStartorStop_Click);
            this.btnStartorStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStartorStop_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "提示操作：准备抽奖--F1    开始/停止--Space";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(807, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lboxLuckyPerson
            // 
            this.lboxLuckyPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lboxLuckyPerson.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxLuckyPerson.FormattingEnabled = true;
            this.lboxLuckyPerson.ItemHeight = 19;
            this.lboxLuckyPerson.Location = new System.Drawing.Point(588, 75);
            this.lboxLuckyPerson.Name = "lboxLuckyPerson";
            this.lboxLuckyPerson.Size = new System.Drawing.Size(268, 422);
            this.lboxLuckyPerson.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(865, 520);
            this.Controls.Add(this.lboxLuckyPerson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStartorStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLuckyPerson);
            this.Controls.Add(this.lbCurrentLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStart_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurrentLevel;
        private System.Windows.Forms.Label lbLuckyPerson;
        private System.Windows.Forms.Button btnStartorStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lboxLuckyPerson;
        private System.Windows.Forms.Timer timer1;
    }
}