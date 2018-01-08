using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //用来表示奖品的实体类
    public class Prize
    {
        public int PrizeID { get; set; }
        public string PrizeLevel { get; set; }
        public int PrizeNumber { get; set; }
        public string PrizeName { get; set; }
    }
}
