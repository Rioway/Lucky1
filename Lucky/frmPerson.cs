using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Common;

namespace Lucky
{
    public partial class frmPerson : Form
    {
        private string filePath = string.Empty;
        private List<Person> objListCurrentPerson = new List<Person>(); 

        public frmPerson()
        {
            InitializeComponent();
            //默认禁用
            gbPersonDetail.Enabled = false;
            //默认加载数据到DataGridView
            dgvPerson.DataSource = null;
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = Program.objListPerson;
        }
        //控件事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.objfrmPerson = null;           
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件|*.csv|TXT文件|*.txt|所有文件|*.*";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
            }

            try
            {
                Program.objListPerson = FileOperator.ReadFile(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show("读取文件出错，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //绑定数据到dataGridView
            dgvPerson.DataSource = null;
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = Program.objListPerson;

            //显示总人数
            lbTotal.Text = Program.objListPerson.Count.ToString();

            //显示人员明细
            if (dgvPerson.Rows.Count == 0) return;
            else
            {
                txtNum.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                txtName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                txtMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
            }
        }

        private void dgvPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPerson.Rows.Count == 0) return;
            else if(dgvPerson.CurrentRow.Selected == false)
            {
                txtNum.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                txtName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                txtMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                txtNum.Text = dgvPerson.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
                txtMobile.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
            }
        }



        //自定义方法
    }
}
