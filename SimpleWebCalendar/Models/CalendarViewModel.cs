using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SimpleWebCalendar.Models
{
    public class CalendarViewModel
    {
        /// <summary></summary>
        public string[] WeekDays = { "日", "月", "火", "水", "木", "金", "土", };

        /// <summary></summary>
        public int year { get; set; }
        /// <summary></summary>
        public int month { get; set; }

        public CalendarViewModel(int year_, int month_)
        {
            this.year = year_;
            this.month = month_;

            this.WeekAndDayList = new List<List<DateTime>>();
            List<DateTime> week = new List<DateTime>();

            CalendarOutput cout = new CalendarOutput(year_, month_);
            cout.ForEachAtOneMonth((date) => {

                week.Add(date);

                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    WeekAndDayList.Add(week);
                    week = new List<DateTime>();
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        public List<List<DateTime>> WeekAndDayList { get; set; }
    }
}
