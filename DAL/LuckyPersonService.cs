using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class LuckyPersonService
    {
        public  List<LuckyPerson> Initialize(List<Prize> objListPrize,bool drawOrder)
        {
            List<LuckyPerson> objListLuckyPerson = new List<LuckyPerson>();
            foreach (Prize item in objListPrize)
            {
                for (int i = 0; i < item.PrizeNumber; i++)
                {
                    objListLuckyPerson.Add(
                        new LuckyPerson
                        {
                            PrizeLevel = item.PrizeLevel,
                            PrizeName = item.PrizeName,
                            Number = item.PrizeNumber,
                        }
                        );
                }
            }
            //如果从小到大抽，需要把内容调换
            if (!drawOrder) objListLuckyPerson.Reverse();
            return objListLuckyPerson;
        }
        public  void WritePersonInfo(string person,LuckyPerson objLuckyPerson)
        {
            string[] personArray = person.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            objLuckyPerson.PersonName = personArray[0];
            objLuckyPerson.Mobile = personArray[1];
        }
    }
}
