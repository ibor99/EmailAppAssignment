using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    public class EmailSender
    {
        public EmailSender() { }

        public void SendEmail(string recipientEmail)
        {
            string senderEmail = "badearo99@gmail.com";
            string password = "ytxz ykyy uhsx zlyp";

            MailMessage mail = new MailMessage(senderEmail, recipientEmail);
            mail.Subject = "Thx for subscribing";
            mail.Body = "Thank you for subscribing to this ( test )";

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(senderEmail, password);
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Failed to send email : {ex.Message}");
            }
            finally
            {
                mail.Dispose();
                client.Dispose();
            }
        }
    }
}
