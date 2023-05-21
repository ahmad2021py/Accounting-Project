using mgh;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utilities
{
    public  class ShamsiDay
    {


        PersianCalendar p;
        public ShamsiDay()
        {
            p = new PersianCalendar();

        }   

        public static string GetThisTimeShamsiDay(DateTime dateTime)
        {

            string ShamsiDay;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                  return  ShamsiDay = "جمعه";
                    break;
                case DayOfWeek.Monday:
                    return ShamsiDay = "دوشنبه";
                    break;
                case DayOfWeek.Saturday:
                    return ShamsiDay = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    return ShamsiDay = "یکشنبه";
                    break;
                case DayOfWeek.Thursday:
                    return ShamsiDay = "پنجشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    return ShamsiDay = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    return ShamsiDay = "چهارشنبه";
                    break;
            }

            return ""; //this Code only for fix C# compiler error: "not all code paths return a value"
        }


		









		//---End Block of Class And Namespace------------------------
	}

}