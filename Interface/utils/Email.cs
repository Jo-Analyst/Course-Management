using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace CourseManagement
{
    class Email
    {
        public static void Enviar(string destinatario, string assunto, string arquivo, string mensagem)
        {

            string email = Security.Dry("zOzPWmbEXC4WCqDvjCJzdSOhl0fNJjo9"),
                senha = Security.Dry("Ir4tk75uw2lrRO6uEzOrJqUie54w0Rin");

            try
            {
                AlternateView alternate = AlternateView.CreateAlternateViewFromString(mensagem, null, MediaTypeNames.Text.Html);
                SmtpClient smtp = new SmtpClient();


                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(email, senha);

                MailMessage mail = new MailMessage();
                mail.AlternateViews.Add(alternate);
                mail.From = new MailAddress(email);

                mail.Attachments.Add(new Attachment(arquivo));

                mail.To.Add(new MailAddress(destinatario));
                mail.Subject = assunto;
                mail.Body = mensagem;
                smtp.Send(mail);
            }
            catch
            {
                throw;
            }
        }
    }
}