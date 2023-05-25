using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Utilities
{
  public static  class AccountingEnums
    {


       public enum IranStates
        {
            آذربایجان_شرقی,
            آذربایجان_غربی,
            اردبیل,
            اصفهان,
            البرز,
            ایلام,
            بوشهر,
            تهران,
            کرمان,
            کردستان,
            قم,
            قزوین,
            فارس,
            سیستان,
            سمنان,
            زنجان,
            خوزستان,
            خراسان_شمالی,
            خراسان_رضوی,
            خراسان_جنوبی,
            چهارمحال,
            یزد,
            همدان,
            هرمزگان,
            مرکزی,
            مازندران,
            لرستان,
            گیلان,
            گلستان,
            کهگیلویه,
            کرمانشاه,

        }

        public static List<string> GetIranStatesList()
        {

            List<string> iranStates = new List<string>();
            iranStates.AddRange(Enum.GetNames(typeof(IranStates)).ToList());
            return iranStates;


        }




















            //---End Block of Class And Namespace------------------------


        }


}