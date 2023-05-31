using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utilities
{
  public static class WorkWithStrings
    {



        public static bool TextToIntVlaidation(string str)
        {
            //--------Summary to use-----
            /* 
           
             WorkWithStrings str = new WorkWithStrings();
             str.TextToIntVlaidation(textBox1.Text);  // Validate Get integer number by TextBox.text.

             string Test1="a"
             string result=str.TextToIntVlaidation(textBox1.Text);  // result is false
             string Test1="4"
             string result=str.TextToIntVlaidation(textBox1.Text);  // result is True



             bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtStockId.Text);
            if (!ValidationResult)
            {
                 MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtStockId.Text = "";
                return;
            }

             */
            //
            int value;
            bool result = int.TryParse(str, out value);
            if (!result)
            {
                //something has gone wrong
                //Text Format is not Correct
                return false;

            }
            return true;
            
        }

        public static bool TextToDecimalVlaidation(string str)
        {
           
            decimal value;
            bool result = decimal.TryParse(str, out value);
            if (!result)
            {
                //something has gone wrong
                //Text Format is not Correct
                return false;

            }
            return true;

        }



        public static bool TextTofloatVlaidation(string str)
        {

            float value;
            bool result = float.TryParse(str, out value);
            if (!result)
            {
                //something has gone wrong
                //Text Format is not Correct
                return false;

            }
            return true;

        }


        public static bool TextToDoubleVlaidation(string str)
        {

            double value;
            bool result = double.TryParse(str, out value);
            if (!result)
            {
                //something has gone wrong
                //Text Format is not Correct
                return false;

            }
            return true;

        }






    



        //------------------------
    }
}
