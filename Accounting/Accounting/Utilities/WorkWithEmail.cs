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


       
    }














    

}
