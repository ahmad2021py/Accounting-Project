namespace Accounting.Utilities
{
    public static class WorkWithStrings
    {


        public static bool StringIsNullOrEmptyOrWhiteSpace(params string[] strings)
        {
            bool[] IsNullOrEmptyResults = new bool[strings.Length];
            bool[] IsNullOrWhiteSpaceResults = new bool[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                IsNullOrEmptyResults[i] = string.IsNullOrEmpty(strings[i]);
                IsNullOrWhiteSpaceResults[i] = string.IsNullOrWhiteSpace(strings[i]);
                if (IsNullOrEmptyResults[i] == true || IsNullOrWhiteSpaceResults[i] == true)
                {
                    return true;
                }
            }

            return false;
        }





        public static bool StringToIntValidations(params string[] strings)
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

            bool[] intValidations = new bool[strings.Length];
            int value;
            for (int i = 0; i < strings.Length; i++)
            {
                intValidations[i] = int.TryParse(strings[i], out value);

                if (!intValidations[i]) // is not int 
                {
                    //something has gone wrong
                    //Text Format is not Correct
                    return false;
                }


            }
            return true;

        }



        public static bool StringToDecimalValidations(params string[] strings)
        {

            bool[] decimalValidations = new bool[strings.Length];
            decimal value;
            for (int i = 0; i < strings.Length; i++)
            {
                decimalValidations[i] = decimal.TryParse(strings[i], out value);

                if (!decimalValidations[i]) // is not int 
                {
                    //something has gone wrong
                    //Text Format is not Correct
                    return false;
                }


            }
            return true;

        }



        public static bool StringToFloatValidations(params string[] strings)
        {

            bool[] floatValidations = new bool[strings.Length];
            float value;
            for (int i = 0; i < strings.Length; i++)
            {
                floatValidations[i] = float.TryParse(strings[i], out value);

                if (!floatValidations[i]) // is not int 
                {
                    //something has gone wrong
                    //Text Format is not Correct
                    return false;
                }


            }
            return true;

        }


        public static bool StringToDoubleValidations(params string[] strings)
        {

            bool[] doubleValidations = new bool[strings.Length];
            float value;
            for (int i = 0; i < strings.Length; i++)
            {
                doubleValidations[i] = float.TryParse(strings[i], out value);

                if (!doubleValidations[i]) // is not int 
                {
                    //something has gone wrong
                    //Text Format is not Correct
                    return false;
                }


            }
            return true;

        }

        public static bool StringToLongValidations(params string[] strings)
        {

            bool[] longValidations = new bool[strings.Length];
            long value;
            for (int i = 0; i < strings.Length; i++)
            {
                longValidations[i] = long.TryParse(strings[i], out value);

                if (!longValidations[i]) // is not int 
                {
                    //something has gone wrong
                    //Text Format is not Correct
                    return false;
                }


            }
            return true;

        }









        //------------------------
    }
}
