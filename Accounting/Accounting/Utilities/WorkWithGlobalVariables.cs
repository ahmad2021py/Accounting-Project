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
        public static string LoginedUserTime;
    }


    public static class WorkWithGlobalForms
    {

        public static frmCategory frmCategory=null;
        public static frmCategoryRecords frmCategoryRecords = null;
        public static frmChangePassword frmChangePassword = null;
        public static frmCompany frmCompany = null;
        public static frmCompanyRecords frmCompanyRecords = null;
        public static frmCustomer frmCustomer = null;
        public static frmCustomerRecords frmCustomerRecords = null;
        public static frmLogin frmLogin = null;
        public static frmLoginDetails frmLoginDetails = null;
        public static frmMainMenu frmMainMenu = null;
        public static frmProduct frmProduct = null;
        public static frmProductRecords frmProductRecords = null;
        public static frmRecoveryPassword frmRecoveryPassword = null;
        public static frmSaleAndBuy frmSaleAndBuy = null;
        public static frmStock frmStock = null;
        public static frmStockRecords frmStockRecords = null;
        public static frmUserRegistration frmUserRegistration = null;
        public static frmUserReords frmUserReords = null;

    }
}
