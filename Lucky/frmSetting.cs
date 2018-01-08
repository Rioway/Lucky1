﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;
using Common;

namespace Lucky
{
    public partial class frmSetting : Form
    {
        private int actionFlag = 0;
        private PrizeService objPrizeService = new PrizeService();

        public frmSetting()
        {
            InitializeComponent();

            //初始化数据
            txtTitle.Text = Program.startTitle;//标题
            if (Program.drawOrder == false) rbStoL.Checked = true;
            else rbLtoS.Checked = true;
            if (Program.drawRepeat == false) rbDenyRepeat.Checked = true;
            else rbRepeat.Checked = true;

            gbPrizeDetail.Enabled = false;
            if (Program.objListPrize == null) 
                Program.objListPrize = new List<Prize>();
            else { }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.objfrmSetting = null;
        }
        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("抽奖标题不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Focus();
                return;
            }
            //为全局变量赋值
            Program.startTitle = txtTitle.Text.Trim();
            //抽奖顺序
            if (rbStoL.Checked == true)
            {
                Program.drawOrder = false;
            }
            else Program.drawOrder = true;
            //重复抽奖
            Program.drawOrder = rbDenyRepeat.Checked ? false : true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)  //为添加做准备
        {
            DisbleButton();
            txtPrizeID.Enabled = false;
            txtPrizeID.Text = objPrizeService.GetNewPrizeID(Program.objListPrize);

            txtPrizeLevel.Text = string.Empty;
            txtPrizeName.Text = string.Empty;
            txtPrizeNumber.Text = string.Empty;

            txtPrizeLevel.Focus();
            actionFlag = 1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)  //为修改做准备
        {
            DisbleButton();
            txtPrizeID.Enabled = false;

            txtPrizeLevel.Focus();
            actionFlag = 2;
        }
        private void btDelete_Click(object sender, EventArgs e)  //删除
        {

        }
        private void btnCommit_Click(object sender, EventArgs e)   //提交添加或者修改
        {
            //对数据进行校验
            if (!ValidataInput()) return;
            //封装数据
            Prize objPrize = new Prize()
            {
                PrizeID = int.Parse(txtPrizeID.Text.Trim()),
                PrizeLevel = txtPrizeLevel.Text.Trim(),
                PrizeNumber = int.Parse(txtPrizeNumber.Text.Trim()),
                PrizeName = txtPrizeName.Text.Trim(),
            };
            //提交修改或者添加
            switch (actionFlag)
            {
                case 1://添加
                    objPrizeService.AddPrize(objPrize, Program.objListPrize);
                    //刷新
                    LoadPrizeInfo(Program.objListPrize);
                    //更新数量
                    lbTotalPrize.Text = (int.Parse(lbTotalPrize.Text) + objPrize.PrizeNumber).ToString();
                    //添加成功
                    MessageBox.Show("添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)    //取消提交或修改
        {
            EnbleButton(); 
            LoadPrizeInfo(Program.objListPrize);
        }

        //自定义方法
        private void DisbleButton()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            gbPrizeDetail.Enabled = true;
        }
        private void EnbleButton()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            gbPrizeDetail.Enabled = false;
        }
        private void LoadPrizeInfo(List<Prize> objList)
        {
            //加载到DataGridView
            dgvPrize.DataSource = null;
            dgvPrize.DataSource = objList;
            if (objList == null||objList.Count == 0)
            {
                txtPrizeID.Text = string.Empty;
                txtPrizeLevel.Text = string.Empty;
                txtPrizeName.Text = string.Empty;
                txtPrizeNumber.Text = string.Empty;
                return;
            }
            else
            {
                txtPrizeID.Text = objList[0].PrizeID.ToString();
                txtPrizeLevel.Text = objList[0].PrizeLevel;
                txtPrizeNumber.Text = objList[0].PrizeNumber.ToString();
                txtPrizeName.Text = objList[0].PrizeName;
            }
        }
        private bool ValidataInput()
        {
            //奖品级别不能为空
            if (string.IsNullOrWhiteSpace(txtPrizeLevel.Text))
            {
                MessageBox.Show("奖品级别不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeLevel.Focus();
                return false; 
            }
            //级别不能重复
            if(actionFlag == 1)
            {
                if (objPrizeService.IsExitPrizeLevel(txtPrizeLevel.Text.Trim(), Program.objListPrize))
                {
                    MessageBox.Show("奖品级别不能为重复！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrizeLevel.Focus();
                    return false;
                }
            }
            //数量
            if (string.IsNullOrWhiteSpace(txtPrizeNumber.Text))
            {
                MessageBox.Show("奖品数量不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeNumber.Focus();
                return false;
            }
            if(!CheckInput.IsNumber(txtPrizeNumber.Text.Trim()) || int.Parse(txtPrizeNumber.Text.Trim()) < 1)
            {
                MessageBox.Show("奖品数量必须填写数字且为正整数！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeNumber.Focus();
                return false;
            }
            //名称
            if (string.IsNullOrWhiteSpace(txtPrizeNumber.Text))
            {
                MessageBox.Show("奖品名称不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeNumber.Focus();
                return false;
            }
            return true;

        }
    }
}
