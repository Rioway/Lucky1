using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmPerson objfrmPerson = null;
        public static frmSetting objfrmSetting = null;
        public static frmStart objfrmStart = null;
        public static frmPresent objfrmPresent = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //打开各个窗体
        private void btnPerson_Click(object sender, EventArgs e)
        {
            if(objfrmPerson == null)
            {
                objfrmPerson = new frmPerson();
                objfrmPerson.Show();
            }
            else
            {
                objfrmPerson.Activate();
                objfrmPerson.WindowState = FormWindowState.Normal;
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (objfrmSetting == null)
            {
                objfrmSetting = new frmSetting();
                objfrmSetting.Show();
            }
            else
            {
                objfrmSetting.Activate();
                objfrmSetting.WindowState = FormWindowState.Normal;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsReady()) return;
            if (objfrmStart == null)
            {
                objfrmStart = new frmStart();
                objfrmStart.Show();
            }
            else
            {
                objfrmStart.Activate();
                objfrmStart.WindowState = FormWindowState.Normal;
            }
        }
        private void btnPresent_Click(object sender, EventArgs e)
        {
            
            if (objfrmPresent == null)
            {
                objfrmPresent = new frmPresent();
                objfrmPresent.Show();
            }
            else
            {
                objfrmPresent.Activate();
                objfrmPresent.WindowState = FormWindowState.Normal;
            }
        }
        private bool IsReady()
        {
            if (Program.objListPerson == null)
            {
                MessageBox.Show("抽奖人员信息没有导入，无法进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Program.startTitle))
            {
                MessageBox.Show("抽奖标题未设置！无法抽奖", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Program.objListPrize == null)
            {
                MessageBox.Show("奖品信息没有添加，无法进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
