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
        #region متد ارسال ایمیل
        public static bool SendMail(EmailPacket emailPacket)
        {
            try
            {
                //instance of MailMessage
                MailMessage Msg = new MailMessage();
                // Sender e-mail address.
                Msg.From = new MailAddress(emailPacket.From);
                // Recipient e-mail address.
                Msg.To.Add(emailPacket.destination);
                Msg.Subject = emailPacket.Subject;
                Msg.Body = emailPacket.Body;
                Msg.IsBodyHtml = true;
                // your remote SMTP server IP.
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(emailPacket.From, emailPacket.From);
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion



    

        /// <summary>
        /// Validates the email input
        /// </summary>
        public static bool IsValidateEmail(string _emailAddress)
        {
             string email = _emailAddress.Trim();
            string _regexPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

            return (string.IsNullOrEmpty(email) == false && System.Text.RegularExpressions.Regex.IsMatch(email, _regexPattern))
                ? true
                : false;
        }












    }
}
