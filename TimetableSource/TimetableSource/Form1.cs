using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableSource
{
    public partial class Form1 : Form
    {
        
        string[] week = new string[2] { "над чертой","под чертой" };
        public Form1()
        {
            InitializeComponent();
            Week.Text+= getWeek();
            Date.Text = DateTime.Now.ToString();
            DrawWeek();
            DrawCurrentDay(getDay());
        }
        private string getDay()
        {
            string day = "";
            DateTime date = DateTime.Now;
            day = date.DayOfWeek.ToString();
            return day;
        }
        private void DrawCurrentDay(string day)
        {
            switch (day)
            {
                case "Mondey":
                    {
                        mon.BackColor = Color.Lavender;
                        break;
                    }
                case "Tuesday":
                    {
                        tue.BackColor = Color.Lavender;
                        break;
                    }
                case "Wednesday":
                    {
                        wed.BackColor = Color.Lavender;
                        break;
                    }
                case "Thursday":
                    {
                        thu.BackColor = Color.Lavender;
                        break;
                    }
                case "Friday":
                    {
                        fri.BackColor = Color.Lavender;
                        break;
                    }
                case "Saturday":
                    {
                        satur.BackColor = Color.Lavender;
                        break;
                    }
                default:
                    {
                        break;
                    }


            }
            
        }
        private string getWeek()
        {
            string weekValue = "";
            DateTime date = DateTime.Now;
            int day = date.Day;
            int w = day / 7;
            if (w % 2 == 0)
                weekValue = week[0];
            else weekValue = week[1];

            return weekValue;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString();
        }
        private void DrawWeek()
        {
            WeekWithTable weekToDraw = new WeekWithTable();

            weekToDraw.initWeek(getWeek(), comboBox1.Text);
            //
            mon.Text = "Понедельник:";
            mon.Text += "\n" + weekToDraw.Mondey.first;
            mon.Text += "\n" + weekToDraw.Mondey.second;
            mon.Text += "\n" + weekToDraw.Mondey.third;
            mon.Text += "\n" + weekToDraw.Mondey.fourth;
            //
            tue.Text = "Вторник";
            tue.Text += "\n" + weekToDraw.Tuesday.first;
            tue.Text += "\n" + weekToDraw.Tuesday.second;
            tue.Text += "\n" + weekToDraw.Tuesday.third;
            tue.Text += "\n" + weekToDraw.Tuesday.fourth;
            //
            wed.Text = "Среда";
            wed.Text += "\n" + weekToDraw.Wednesday.first;
            wed.Text += "\n" + weekToDraw.Wednesday.second;
            wed.Text += "\n" + weekToDraw.Wednesday.third;
            wed.Text += "\n" + weekToDraw.Wednesday.fourth;
            //
            thu.Text = "Четверг";
            thu.Text+= "\n" + weekToDraw.Thursday.first;
            thu.Text += "\n" + weekToDraw.Thursday.second;
            thu.Text += "\n" + weekToDraw.Thursday.third;
            thu.Text += "\n" + weekToDraw.Thursday.fourth;
            //
            fri.Text = "Пятница";
            fri.Text += "\n" + weekToDraw.Friday.first;
            fri.Text += "\n" + weekToDraw.Friday.second;
            fri.Text += "\n" + weekToDraw.Friday.third;
            fri.Text += "\n" + weekToDraw.Friday.fourth;
            //
            satur.Text = "Суббота";
            satur.Text += "\n" + weekToDraw.Saturday.first;
            satur.Text += "\n" + weekToDraw.Saturday.second;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                DrawWeek();
        }
    }
}
