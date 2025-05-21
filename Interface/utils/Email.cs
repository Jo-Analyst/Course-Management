using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace CourseManagement
{
    class Email
    {
        public static void Enviar(string recipient, string subject, string file, string message)
        {

            string email = Security.Dry("zOzPWmbEXC4WCqDvjCJzdSOhl0fNJjo9"),
                password = Security.Dry("HozQfjaDRWNL7bCByi37Px+AsGPy+3Sz");

            try
            {
                AlternateView alternate = AlternateView.CreateAlternateViewFromString(message, null, MediaTypeNames.Text.Html);
                SmtpClient smtp = new SmtpClient();


                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(email, password);

                MailMessage mail = new MailMessage();
                mail.AlternateViews.Add(alternate);
                mail.From = new MailAddress(email);

                mail.Attachments.Add(new Attachment(file));

                mail.To.Add(new MailAddress(recipient));
                mail.Subject = subject;
                mail.Body = message;
                smtp.Send(mail);
            }
            catch
            {
                throw;
            }
        }
    }
}