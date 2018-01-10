using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Lucky
{
    public partial class frmStart : Form
    {
        private LuckyPersonService objLuckyPersonService = new LuckyPersonService();
        private PersonService objPersonService = new PersonService();
        private bool IsCurrentLevelOver = false;  //当前级别抽奖结束
        private bool IsDrawOver = false;  //抽奖结束
        private int sumofPrize = 0;  //奖项数量
        private int sumofDrawed = 0; //已抽奖数量
        private int totalofDraw = 0;//总共奖项数量
        public frmStart()
        {
            InitializeComponent();

            //初始化数据
            lbTitle.Text = "【" + Program.startTitle + "】";
            if(Program.objListLuckyPerson == null)
            {
                Program.objListLuckyPerson = objLuckyPersonService.Initialize(Program.objListPrize, Program.drawOrder);
                sumofPrize = Program.objListLuckyPerson.Count;
            }
        }
        //控件事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.objfrmStart = null;
        }
        private void btnStartorStop_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 112)
            {
                //清空listbox
                lboxLuckyPerson.Items.Clear();
                //初始化奖品label
                lbCurrentLevel.Text = Program.objListLuckyPerson[totalofDraw].PrizeLevel + "      " +
                                      "奖品：" + Program.objListLuckyPerson[totalofDraw].PrizeName + "      " +
                                      "共：" + Program.objListLuckyPerson[totalofDraw].Number + "名";
                lboxLuckyPerson.Items.Add( Program.objListLuckyPerson[totalofDraw].PrizeLevel + "    共：" + Program.objListLuckyPerson[totalofDraw].Number + "名");
                //控制当前抽奖是否结束标签
                IsCurrentLevelOver = false;
                //当前级别的计数设置为零
                sumofDrawed = 0;
            }
        }

        private void btnStartorStop_Click(object sender, EventArgs e)
        {
            //判断当前抽奖是否全部结束
            if (IsDrawOver)
            {
                MessageBox.Show( "所有奖项抽取完毕，请在中奖查询窗体中查询中奖信息", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsCurrentLevelOver)
            {
                MessageBox.Show(Program.objListLuckyPerson[sumofDrawed - 1].PrizeLevel + "抽奖结束，中奖人员在右侧列表中！");
                return;
            }
            //判断当前级别的抽奖是否结束

            //开始执行
            if(btnStartorStop.Text.Contains("开始"))
            {
                btnStartorStop.Text = "停止";

                timer1.Enabled = true;
            }
            //停止
            else
            {
                btnStartorStop.Text = "开始";

                timer1.Enabled = false;
                //中奖数量+1
                sumofDrawed++;
                totalofDraw++;
                //把中奖信息填入到listbox
                lboxLuckyPerson.Items.Add(Convert.ToString(sumofDrawed)+"、"+lbLuckyPerson.Text);
                objLuckyPersonService.WritePersonInfo(lbLuckyPerson.Text, Program.objListLuckyPerson[totalofDraw - 1]);
                //如果不允许重复中奖，把中奖名单从List中删除
                if(!Program.drawRepeat)
                {
                    objPersonService.RemovePersonfromList(lbLuckyPerson.Text, Program.objListPerson);
                }
                //判断当前级别抽奖是否结束
                if(sumofDrawed == Program.objListLuckyPerson[totalofDraw - 1].Number)
                {
                    //当前级别抽奖结束
                    IsCurrentLevelOver = true;
                    lbCurrentLevel.Text = Program.objListLuckyPerson[totalofDraw - 1].PrizeLevel + "抽奖结束，恭喜中奖人员！";
                }
                if(totalofDraw == sumofPrize)
                {
                    IsDrawOver = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbLuckyPerson.Text = objPersonService.GetOnePerson(Program.objListPerson);
        }


        //自定义时间

    }
}
