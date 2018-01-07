using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Lucky
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        //定义全局的静态数据
        //【1】人员信息中所有人员明细
        public static List<Person> objListPerson = null;

        //----抽奖设置----//
        //【2】标题
        public static string startTitle = null;
        //【3】抽奖顺序设置
        public static bool drawOrder = false;
        //【4】重复中奖设置
        public static bool drawRepeat = false;
        //【5】奖品的明细
        // public  static List<Present> objListPresent = null;

        //【6】中奖者信息
        // public static List<LuckyPerson> objListLuckyPerson = null;
    }
}
