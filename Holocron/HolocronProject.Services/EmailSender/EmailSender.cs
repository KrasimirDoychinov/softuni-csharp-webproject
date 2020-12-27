using System.Net.Mail;

namespace HolocronProject.Services.EmailSender
{
    public class EmailSender : IEmailSender
    {
        public void SendConfirmationEmail(Data.Models.Account account, string confirmationLink)
        {
            confirmationLink = confirmationLink.Replace("/Identity", "");
            MailMessage mail = new MailMessage();
            mail.To.Add(account.Email);

            mail.From = new MailAddress("holocronAutomaticSender@gmail.com");
            mail.Subject = "Holocron verification email";


            mail.Body = $"<p>Your verification link: <a href=\"{confirmationLink}\">Click me.</a></p>";

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential
                 ("holocronAutomaticSender@gmail.com", "holocronAutomaticSender1!");

            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
        
    }
}
