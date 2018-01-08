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
using DAL;

namespace Lucky
{
    public partial class frmPerson : Form
    {
        private string filePath = string.Empty;
        private List<Person> objListQuery = new List<Person>();
        private PersonService objPersonService = new PersonService();
        private int actionFlag = 0;  //标识增加还是修改


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

        //模块1：导入数据和呈现数据：选则文件-->读取文件到List-->展示在datagridview中-->展示明细
        //模块2：人员信息查询：所有的人员：Program.objListPerson
        //                     满足条件的人员：objListQuery
        //模块3：人员增删改：先修改List<Person>，再更新到DataGridView
        //模块4：人员信息保存-----Program.objListPerson保存了所有的最新人员信息-->删除原先的数据，把List信息写入

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
                try
                {
                    txtNum.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                    txtName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                    txtMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
                }
                catch
                {
                    return;
                }
                
            }
            else
            {
                if (dgvPerson.Rows[0] != null)
                {
                    txtNum.Text = dgvPerson.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
                    txtMobile.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
                }
                else return;
            }
        }
        private void txtQueryName_TextChanged(object sender, EventArgs e)
        {
            //清空objListQuery
            objListQuery.Clear();
            //获取满足条件的Person
            objListQuery = objPersonService.GetAllPersonByName(txtQueryName.Text.Trim(), Program.objListPerson);
            //绑定到DataGridView
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = objListQuery;

        }
        private void txtQueryMobile_TextChanged(object sender, EventArgs e)
        {
            //清空objListQuery
            objListQuery.Clear();
            //获取满足条件的Person
            objListQuery = objPersonService.GetAllPersonByMobile(txtQueryMobile.Text.Trim(), Program.objListPerson);
            //绑定到DataGridView
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = objListQuery;
        }
        private void btnAdd_Click(object sender, EventArgs e) //为添加做准备
        {
            DisableButton();
            txtNum.Enabled = false;
            //自动填充ID
            txtNum.Text = objPersonService.GetNewPerson(Program.objListPerson);
            txtName.Text = string.Empty;
            txtMobile.Text = string.Empty;

            txtNum.Focus();
            actionFlag = 1;
        }
        private void btnUpdate_Click(object sender, EventArgs e) //为修改做准备
        {
            DisableButton();
            txtNum.Enabled = false;

            txtNum.Focus();
            actionFlag = 2;
        }
        private void btnCommit_Click(object sender, EventArgs e) //提交添加或者修改
        {
            //判断输入
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("姓名不允许为空！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if(CheckInput.IsChinese(txtName.Text))
            {
                MessageBox.Show("姓名必须为中文！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                MessageBox.Show("号码不允许为空！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobile.Focus();
                return;
            }
            if (CheckInput.IsMobile(txtMobile.Text.Trim()))
            {
                MessageBox.Show("号码必须为11位数字！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobile.Focus();
                return;
            }

            Person objPerson = new Person()
            {
                PersonID = Convert.ToInt32(txtNum.Text.Trim()),
                PersonName = txtName.Text,
                PersonMobile = txtMobile.Text.Trim(),
            };

            switch(actionFlag)
            {
                case 1:
                    objPersonService.AddPerson(objPerson, Program.objListPerson);

                    dgvPerson.DataSource = null;
                    dgvPerson.DataSource = Program.objListPerson;

                    txtNum.Text = dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[0].Value.ToString();
                    txtNum.Text = dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[1].Value.ToString();
                    txtNum.Text = dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[2].Value.ToString();

                    lbTotal.Text = (int.Parse(lbTotal.Text) + 1).ToString();

                    EnableButton();
                    MessageBox.Show("添加成功！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    objPersonService.UpdatePerson(objPerson, Program.objListPerson);

                    dgvPerson.DataSource = null;
                    dgvPerson.DataSource = Program.objListPerson;

                    EnableButton();
                    MessageBox.Show("修改成功！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)  //取消添加，修改
        {
            EnableButton();
            if (dgvPerson.Rows.Count == 0) return;
            if(actionFlag == 1)
            {
                txtNum.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                txtName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                txtMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPerson.Rows.Count == 0) return;
            else if (dgvPerson.CurrentRow.Selected == false) return;
            else
            {
                string info = "您确定删除人员【编号：" + dgvPerson.CurrentRow.Cells[0].Value.ToString() + "  姓名：" + dgvPerson.CurrentRow.Cells[1].Value.ToString() + "  电话：" + dgvPerson.CurrentRow.Cells[2].Value.ToString() + "】信息吗？";
                DialogResult result = MessageBox.Show(info, "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    objPersonService.DeletePerson(dgvPerson.CurrentRow.Cells[0].Value.ToString(), Program.objListPerson);
                    dgvPerson.DataSource = null;
                    dgvPerson.DataSource = Program.objListPerson;

                    txtNum.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                    txtNum.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                    txtNum.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();

                    lbTotal.Text = (int.Parse(lbTotal.Text) + 1).ToString();

                    EnableButton();
                    MessageBox.Show("删除成功！", "系统消息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(FileOperator.WriteFile(filePath,Program.objListPerson))
                {
                    MessageBox.Show("保存成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存数据失败！具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //自定义方法
        private void DisableButton()
        {
            btnImport.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;

            gbPersonDetail.Enabled = true;
        }
        private void EnableButton()
        {
            btnImport.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;

            gbPersonDetail.Enabled = false;
        }
    }
}
