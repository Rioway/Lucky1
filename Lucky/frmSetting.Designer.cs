namespace Lucky
{
    partial class frmSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrizeNumber = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrizeLevel = new System.Windows.Forms.TextBox();
            this.txtPrizeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPrize = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrizeDetail = new System.Windows.Forms.GroupBox();
            this.txtPrizeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDenyRepeat = new System.Windows.Forms.RadioButton();
            this.rbRepeat = new System.Windows.Forms.RadioButton();
            this.rbStoL = new System.Windows.Forms.RadioButton();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.rbLtoS = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotalPrize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrize)).BeginInit();
            this.gbPrizeDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(811, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(762, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(762, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(762, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(565, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrizeNumber
            // 
            this.txtPrizeNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrizeNumber.Location = new System.Drawing.Point(453, 29);
            this.txtPrizeNumber.Name = "txtPrizeNumber";
            this.txtPrizeNumber.Size = new System.Drawing.Size(95, 26);
            this.txtPrizeNumber.TabIndex = 4;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCommit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCommit.Location = new System.Drawing.Point(565, 21);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(69, 30);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(405, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "数量：";
            // 
            // txtPrizeLevel
            // 
            this.txtPrizeLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrizeLevel.Location = new System.Drawing.Point(264, 29);
            this.txtPrizeLevel.Name = "txtPrizeLevel";
            this.txtPrizeLevel.Size = new System.Drawing.Size(99, 26);
            this.txtPrizeLevel.TabIndex = 4;
            // 
            // txtPrizeID
            // 
            this.txtPrizeID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrizeID.Location = new System.Drawing.Point(58, 29);
            this.txtPrizeID.Name = "txtPrizeID";
            this.txtPrizeID.Size = new System.Drawing.Size(99, 26);
            this.txtPrizeID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(217, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "级别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(10, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "编号：";
            // 
            // dgvPrize
            // 
            this.dgvPrize.AllowUserToAddRows = false;
            this.dgvPrize.AllowUserToDeleteRows = false;
            this.dgvPrize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrizeID,
            this.PrizeLevel,
            this.PrizeNumber,
            this.PrizeName});
            this.dgvPrize.EnableHeadersVisualStyles = false;
            this.dgvPrize.Location = new System.Drawing.Point(200, 180);
            this.dgvPrize.Name = "dgvPrize";
            this.dgvPrize.ReadOnly = true;
            this.dgvPrize.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPrize.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrize.RowTemplate.Height = 23;
            this.dgvPrize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrize.Size = new System.Drawing.Size(545, 221);
            this.dgvPrize.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "抽奖标题：";
            // 
            // gbPrizeDetail
            // 
            this.gbPrizeDetail.Controls.Add(this.btnCancel);
            this.gbPrizeDetail.Controls.Add(this.txtPrizeNumber);
            this.gbPrizeDetail.Controls.Add(this.btnCommit);
            this.gbPrizeDetail.Controls.Add(this.label5);
            this.gbPrizeDetail.Controls.Add(this.txtPrizeLevel);
            this.gbPrizeDetail.Controls.Add(this.txtPrizeName);
            this.gbPrizeDetail.Controls.Add(this.txtPrizeID);
            this.gbPrizeDetail.Controls.Add(this.label7);
            this.gbPrizeDetail.Controls.Add(this.label4);
            this.gbPrizeDetail.Controls.Add(this.label6);
            this.gbPrizeDetail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbPrizeDetail.Location = new System.Drawing.Point(202, 407);
            this.gbPrizeDetail.Name = "gbPrizeDetail";
            this.gbPrizeDetail.Size = new System.Drawing.Size(648, 95);
            this.gbPrizeDetail.TabIndex = 12;
            this.gbPrizeDetail.TabStop = false;
            this.gbPrizeDetail.Text = "奖品信息";
            // 
            // txtPrizeName
            // 
            this.txtPrizeName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrizeName.Location = new System.Drawing.Point(58, 64);
            this.txtPrizeName.Name = "txtPrizeName";
            this.txtPrizeName.Size = new System.Drawing.Size(490, 26);
            this.txtPrizeName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "奖品：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLtoS);
            this.groupBox1.Controls.Add(this.rbStoL);
            this.groupBox1.Controls.Add(this.btnSaveSetting);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(200, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "抽奖基本设置";
            // 
            // rbDenyRepeat
            // 
            this.rbDenyRepeat.AutoSize = true;
            this.rbDenyRepeat.Checked = true;
            this.rbDenyRepeat.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbDenyRepeat.Location = new System.Drawing.Point(8, 3);
            this.rbDenyRepeat.Name = "rbDenyRepeat";
            this.rbDenyRepeat.Size = new System.Drawing.Size(125, 23);
            this.rbDenyRepeat.TabIndex = 5;
            this.rbDenyRepeat.TabStop = true;
            this.rbDenyRepeat.Text = "不允许重复中奖";
            this.rbDenyRepeat.UseVisualStyleBackColor = true;
            // 
            // rbRepeat
            // 
            this.rbRepeat.AutoSize = true;
            this.rbRepeat.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbRepeat.Location = new System.Drawing.Point(176, 1);
            this.rbRepeat.Name = "rbRepeat";
            this.rbRepeat.Size = new System.Drawing.Size(111, 23);
            this.rbRepeat.TabIndex = 5;
            this.rbRepeat.Text = "允许重复中奖";
            this.rbRepeat.UseVisualStyleBackColor = true;
            // 
            // rbStoL
            // 
            this.rbStoL.AutoSize = true;
            this.rbStoL.Checked = true;
            this.rbStoL.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbStoL.Location = new System.Drawing.Point(98, 63);
            this.rbStoL.Name = "rbStoL";
            this.rbStoL.Size = new System.Drawing.Size(111, 23);
            this.rbStoL.TabIndex = 5;
            this.rbStoL.TabStop = true;
            this.rbStoL.Text = "从小奖到大奖";
            this.rbStoL.UseVisualStyleBackColor = true;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveSetting.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveSetting.Location = new System.Drawing.Point(501, 63);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(74, 64);
            this.btnSaveSetting.TabIndex = 17;
            this.btnSaveSetting.Text = "保存";
            this.btnSaveSetting.UseVisualStyleBackColor = false;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // rbLtoS
            // 
            this.rbLtoS.AutoSize = true;
            this.rbLtoS.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbLtoS.Location = new System.Drawing.Point(268, 63);
            this.rbLtoS.Name = "rbLtoS";
            this.rbLtoS.Size = new System.Drawing.Size(111, 23);
            this.rbLtoS.TabIndex = 5;
            this.rbLtoS.Text = "从大奖到小奖";
            this.rbLtoS.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(89, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(486, 29);
            this.txtTitle.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(90, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 30);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRepeat);
            this.panel1.Controls.Add(this.rbDenyRepeat);
            this.panel1.Location = new System.Drawing.Point(90, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 30);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "中奖设置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "抽奖顺序：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lucky.Properties.Resources.timg2jpg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 503);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotalPrize
            // 
            this.lbTotalPrize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalPrize.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalPrize.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPrize.Location = new System.Drawing.Point(282, 150);
            this.lbTotalPrize.Name = "lbTotalPrize";
            this.lbTotalPrize.Size = new System.Drawing.Size(74, 22);
            this.lbTotalPrize.TabIndex = 18;
            this.lbTotalPrize.Text = "0";
            this.lbTotalPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(202, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "奖品人数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(552, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "添加奖品：从大奖到小奖添加";
            // 
            // PrizeID
            // 
            this.PrizeID.DataPropertyName = "PrizeID";
            this.PrizeID.HeaderText = "编号";
            this.PrizeID.Name = "PrizeID";
            this.PrizeID.ReadOnly = true;
            this.PrizeID.Width = 80;
            // 
            // PrizeLevel
            // 
            this.PrizeLevel.DataPropertyName = "PrizeLevel";
            this.PrizeLevel.HeaderText = "级别";
            this.PrizeLevel.Name = "PrizeLevel";
            this.PrizeLevel.ReadOnly = true;
            this.PrizeLevel.Width = 120;
            // 
            // PrizeNumber
            // 
            this.PrizeNumber.DataPropertyName = "PrizeNumber";
            this.PrizeNumber.HeaderText = "数量";
            this.PrizeNumber.Name = "PrizeNumber";
            this.PrizeNumber.ReadOnly = true;
            // 
            // PrizeName
            // 
            this.PrizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrizeName.DataPropertyName = "PrizeName";
            this.PrizeName.HeaderText = "奖品";
            this.PrizeName.Name = "PrizeName";
            this.PrizeName.ReadOnly = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(867, 514);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTotalPrize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPrize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPrizeDetail);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrize)).EndInit();
            this.gbPrizeDetail.ResumeLayout(false);
            this.gbPrizeDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrizeNumber;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrizeLevel;
        private System.Windows.Forms.TextBox txtPrizeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPrize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPrizeDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrizeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDenyRepeat;
        private System.Windows.Forms.RadioButton rbRepeat;
        private System.Windows.Forms.RadioButton rbStoL;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.RadioButton rbLtoS;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotalPrize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeName;
    }
}