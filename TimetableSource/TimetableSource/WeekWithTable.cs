using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableSource
{
    class WeekWithTable
    {
        public Day Mondey { set; get; }
        public Day Tuesday { set; get; }
        public Day Wednesday { set; get; }
        public Day Thursday { set; get; }
        public Day Friday { set; get; }
        public Day Saturday { set; get; }

        public void initWeek(string param, string group)
        {
            Mondey = new Day();
            Tuesday = new Day();
            Wednesday = new Day();
            Thursday = new Day();
            Friday = new Day();
            Saturday = new Day();
            if (param == "над чертой" && group == "19-ИД-3 \"А\"")
            {
                
                Mondey.first += "Физ-ра";
                Mondey.second += "МОИС(лк)";
                Mondey.third += "ИТ(лк)";

                Tuesday.first += "Мат. анализ(пр)";
                Tuesday.second += "ИТ(пр)";
                Tuesday.third += "Мат. анализ(лк)";

                Wednesday.first += "Физ-ра";
                Wednesday.second += "ООП(лк)";
                Wednesday.third += "ОВТ(лк)";
                Wednesday.fourth += "ООП(пр)";

                Thursday.first += "Уч. практика";
                Thursday.second += "Уч. практика";
                Thursday.third += "Уч. практика";

                Friday.first += "МОИС(пр)";
                Friday.second += "ТВиМС(лк)";
                Friday.third += "ТВиМС(пр)";
                Friday.fourth += "Англ. яз(пр)";

                Saturday.first += "ОВТ(пр)";
                Saturday.second += "СПиКМ(лк)";
            }
            if (param == "под чертой" && group == "19-ИД-3 \"А\"")
            {
                Mondey.first += "Физ-ра";
                Mondey.second += "Англ. яз";

                Tuesday.first += "Мат. анализ(пр)";
                Tuesday.second += "ТРПО(пр)";
                Tuesday.third += "Мат. анализ(лк)";

                Wednesday.first += "Физ-ра";
                Wednesday.second += "ООП(лк)";
                Wednesday.third += "ТРПО(лк)";
                Wednesday.fourth += "ООП(пр)";

                Thursday.first += "Уч. практика";
                Thursday.second += "Уч. практика";
                Thursday.third += "Уч. практика";

                Friday.second += "История(лк)";
                Friday.third += "История(пр)";
                

                Saturday.first += "СПиКМ(пр)";

            }
            if (param == "над чертой" && group == "19-ИД-3 \"Б\"")
            {

                Mondey.first += "Физ-ра";
                Mondey.second += "МОИС(лк)";
                Mondey.third += "ИТ(лк)";

                Tuesday.first += "Мат. анализ(пр)";
                Tuesday.second += "ООП(пр)";
                Tuesday.third += "Мат. анализ(лк)";

                Wednesday.first += "Физ-ра";
                Wednesday.second += "ООП(лк)";
                Wednesday.third += "ОВТ(лк)";
                Wednesday.fourth += "Англ. яз(пр)";

                Thursday.first += "Уч. практика";
                Thursday.second += "Уч. практика";
                Thursday.third += "Уч. практика";

                Friday.first += "ТРПО(пр)";
                Friday.second += "ТВиМС(лк)";
                Friday.third += "ТВиМС(пр)";
                

                Saturday.first += "ОВТ(пр)";
                Saturday.second += "СПиКМ(лк)";
            }
            if (param == "под чертой" && group == "19-ИД-3 \"Б\"")
            {
                Mondey.first += "Физ-ра";
                Mondey.second += "МОИС(пр)";

                Tuesday.first += "Мат. анализ(пр)";
                Tuesday.second += "ООП(пр)";
                Tuesday.third += "Мат. анализ(лк)";

                Wednesday.first += "Физ-ра";
                Wednesday.second += "ООП(лк)";
                Wednesday.third += "ТРПО(лк)";
                Wednesday.fourth += "Англ. яз";

                Thursday.first += "Уч. практика";
                Thursday.second += "Уч. практика";
                Thursday.third += "Уч. практика";

                Friday.first += "ИТ(пр)";
                Friday.second += "История(лк)";
                Friday.third += "История(пр)";


                Saturday.first += "СПиКМ(пр)";

            }
        }

    }
}
