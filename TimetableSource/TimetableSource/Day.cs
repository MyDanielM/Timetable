using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableSource
{
    class Day
    {
        public string first { set; get; }
        public string second { set; get; }
        public string third { set; get; }
        public string fourth { set; get; }
        public string fifth { set; get; }
        public Day()
        {
            first =  "08:30 - 10:00 - ";
            second = "10:10 - 11:40 - ";
            third =  "11:50 - 13:20 - ";
            fourth = "14:00 - 15:30 - ";
            fifth =  "15:40 - 17:00 - ";
        }
    }
}
