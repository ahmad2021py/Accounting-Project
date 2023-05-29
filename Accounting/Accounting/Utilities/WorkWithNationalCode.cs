using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utilities
{
    public static class WorkWithNationalCode
    {
       public static bool NationalCodeValidation(string nationalCode)
        {


            if (nationalCode.Length < 8 || nationalCode.Length > 10)
            {
               // Not Valid
                return false;
            }
            
            int sum = 0;
            string codeMeli = nationalCode;
            if (codeMeli.Length >= 8 && codeMeli.Length < 10)
            {
                //add 00 or 0 to start of code
                codeMeli = "00".Substring(0, 10 - codeMeli.Length) + codeMeli;
            }
            for (byte i = 0; i < 9; ++i)
            {
                sum += (Convert.ToInt32(codeMeli[i]) - 48) * (10 - i);

            }
            sum = sum % 11;
            if (sum < 2 && int.Parse(codeMeli[9].ToString()) != sum)
            {
              // Not Valid
                return false;
            }

            return true ;
        }




        public static string AddZeroToStartNationalCodeIfWant(string nationalCode)
        {


            //if (nationalCode.Length < 8 || nationalCode.Length > 10)
            //{
            //    // Not Valid
            //    return "NotValid";
            //}

            //int sum = 0;
            string codeMeli = nationalCode;
            if (codeMeli.Length >= 8 && codeMeli.Length < 10)
            {
                //add 00 or 0 to start of code
                codeMeli = "00".Substring(0, 10 - codeMeli.Length) + codeMeli;
            }
            //for (byte i = 0; i < 9; ++i)
            //{
            //    sum += (Convert.ToInt32(codeMeli[i]) - 48) * (10 - i);

            //}
            //sum = sum % 11;
            //if (sum < 2 && int.Parse(codeMeli[9].ToString()) != sum)
            //{
            //    // Not Valid
            //    return "NotValid";
            //}

            return codeMeli;
        }
















    }
}
