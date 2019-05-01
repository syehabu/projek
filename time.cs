using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum
{
    class Time
    {
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        // constructor
        public Time()
        {
            year = 2018;
            month = 10;
            date = 10;
            hour = 10;
            minute = 30;
            second = 40;
        }




    }
     
}

