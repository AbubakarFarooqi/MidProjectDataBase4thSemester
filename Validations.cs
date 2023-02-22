using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    public static class Validations
    {
        // this fucntion check whther there is number in a given stirng
        public static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        // this function will return number of month
        public static int getMonthNumber(string month)
        {
            if (month == "January")
                return 1;
            if (month == "February")
                return 2;
            if (month == "March")
                return 3;
            if (month == "April")
                return 4;
            if (month == "May")
                return 5;
            if (month == "June")
                return 6;
            if (month == "July")
                return 7;
            if (month == "August")
                return 8;
            if (month == "September")
                return 9;
            if (month == "October")
                return 10;
            if (month == "November")
                return 11;
            if (month == "December")
                return 12;
            return -1;
        }
        //this funtion will parse date 
        public static string parseDate(string date)
        {
            string[] temp = date.Split(',');
            string year = temp[2];
            string[] monthAndDay = temp[1].Split(' ');
            string month = monthAndDay[1];
            string day = monthAndDay[2];
            return year + "-" + getMonthNumber(month) + "-" + day;

        }
    }
}
