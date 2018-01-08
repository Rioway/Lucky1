using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class PrizeService
    {
        public string GetNewPrizeID(List<Prize> objListPrize)
        {
            if (objListPrize == null || objListPrize.Count == 0) return "1";
            else
            {
                return (objListPrize[objListPrize.Count - 1].PrizeID + 1).ToString();
            }
        }
        public bool IsExitPrizeLevel(string level,List<Prize> objList)
        {
            if (objList == null) return false;
            foreach (Prize item in objList)
            {
                if(item.PrizeLevel.Contains(level))
                {
                    return true;
                }
            }
            return false;
        }
        public void  AddPrize(Prize objPrize,List<Prize> objList)
        {
            objList.Add(objPrize);
        }
        public void UpdatePrize(Prize objPrize, List<Prize> objList)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                if(objList[i].PrizeID == objPrize.PrizeID)
                {
                    objList.RemoveAt(i);
                    objList.Insert(i, objPrize);
                    break;
                }
            }
        }
        public void DeletePrize(string prizeID, List<Prize> objList)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].PrizeID == int.Parse(prizeID))
                {
                    objList.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
