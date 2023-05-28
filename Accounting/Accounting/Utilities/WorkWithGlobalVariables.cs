using Accounting.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utilities
{
    public static class WorkWithGlobalVariables
    {
        public static string LoginedUserName;
        public static string LoginedUserRole;
        public static DateTime LoginedUserTime;
    }


    public static class WorkWithGlobalForms
    {
        public static  frmMainMenu frmMainMenu=null;
        public static  frmCategory frmCategory = null;
        public static  frmSaleAndBuy frmSaleAndBuy = null;

        public static string LoginedUserRole;
        public static DateTime LoginedUserTime;
    }
}
