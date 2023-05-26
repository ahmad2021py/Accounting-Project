
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Utilities
{

    /*-----ReadMe-------------------------
      Sample to use ShamsiToMiladi method :
      string Miladi= _workWithDate.ShamsiToMiladi("1402/03/06"); 
    or 
         string ShamsiDate = "1402/03/06";
            string Miladi= _workWithDate.ShamsiToMiladi(ShamsiDate);
    //-----
    Sample to use MiladiToShamsi method :
      WorkWithDate _workWithDate = new WorkWithDate();
           
            DateTime Miladi= _workWithDate.ShamsiToMiladi("1402/03/06");

            MessageBox.Show(Miladi.ToString());
    //-----



        */
    public class WorkWithDate
    {

        PersianCalendar p;
        public WorkWithDate()
        {
            p = new PersianCalendar();
        }
        string dat, sal, mah, roz, ret;
        public DateTime ShamsiToMiladi(string ShamsiDate)
        {
            dat = ShamsiDate;
            sal = dat.Substring(0, 4);
            mah = dat.Substring(5, 2);
            roz = dat.Substring(8, 2);
            PersianCalendar pc = new PersianCalendar();
            ret = pc.ToDateTime(Convert.ToInt32(sal), Convert.ToInt32(mah), Convert.ToInt32(roz), 0, 0, 0, 0).ToString();

            var MiladiDate = DateTime.Parse(ret);
            return MiladiDate;
        }



        public string MiladiToShamsi(DateTime MiladiDate)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            sb.Append(pc.GetYear(MiladiDate).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(MiladiDate).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(MiladiDate).ToString("00"));
            return sb.ToString();

        }



        public  string GetShamsiDayNameByMiladiDate(DateTime dateTime)
        {

            string ShamsiDay;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    return ShamsiDay = "جمعه";
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











        //-----------------------
    }

}