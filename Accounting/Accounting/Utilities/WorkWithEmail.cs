using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utilities
{

    public static class WorkWithEmail
    {
        #region SendRecoveryMail Method
        public async static Task<bool> SendRecoveryMail(SupportEmailPacket supportEmailPacket )
        {
            return await Task.Run(() =>
            {
                try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                MailAddress from = new MailAddress(supportEmailPacket.SenderMailAddress, supportEmailPacket.SenderDisplayName);
                MailAddress to = new MailAddress(supportEmailPacket.TargetMailAddress, supportEmailPacket.targetDisplayName);
                 
                MailMessage message = new MailMessage(supportEmailPacket.SenderMailAddress, supportEmailPacket.TargetMailAddress);
                message.Subject = supportEmailPacket.Subject;
                message.Body = supportEmailPacket.Body;
                NetworkCredential myCreds = new NetworkCredential("ahmadx3nfc2021@gmail.com", "llhsuvqdcsbniofm", ""); //Enable 2-Step Verification. App Password.
                client.Credentials = myCreds;
                client.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
            });
        }
        #endregion





        /// <summary>
        /// Validates the email input
        /// </summary>
      async  public static Task<bool> IsValidateEmail(string _emailAddress)
        {
            return await Task.Run(() =>
            {
                string email = _emailAddress.Trim();
            string _regexPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

            return (string.IsNullOrEmpty(email) == false && System.Text.RegularExpressions.Regex.IsMatch(email, _regexPattern))
                ? true
                : false;
            });
        }



        #region SupportEmailPacket Class
        public class SupportEmailPacket
        {
            public SupportEmailPacket(string TargetMailAddress, string targetUserName, string targetPassword)
            {
                _TargetMailAddress = TargetMailAddress;
                _targetPassword = targetPassword;
                _targetDisplayName = targetUserName;

            }


            private readonly string _TargetMailAddress;
            private readonly string _targetDisplayName;
            private readonly string _targetPassword;

            public string SenderMailAddress
            {
                get
                {
                    return "ahmadx3nfc2021@gmail.com";
                }
            }
            public string SenderDisplayName
            {
                get
                {
                    return "پشتیبانی برنامه حسابداری";


                }
            }
            public string Subject
            {
                get
                {
                    return "بازیابی کلمه عبور-برنامه حسابداری";
                }
            }
            public string Body
            {
                get
                {
                    return string.Format("کلمه عبور شما  :  \n {0}", _targetPassword);
                }
            }

            public string targetDisplayName
            { 
                get
                {

                    return _targetDisplayName;


                } 
            }

            public string targetPassword
            {
                get
                {

                    return _targetPassword;


                }
            }




            public string TargetMailAddress
            {
                get
                {

                    return _TargetMailAddress;


                }
            }
        }


    #endregion





    //--------------------------------------------------------

}
}
