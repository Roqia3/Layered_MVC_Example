using System.Net.Mail;
using System.Threading.Tasks;
namespace MVC_Example.BusinessLayer.Services.Email
{
    public interface IEmailService
    {
        Task SendEmail(string recipientEmail, string subject, string body);
    }
    
    public class EmailService : IEmailService
    {
        public async Task SendEmail(string recipientEmail, string subject, string body)
        {
            // Configure the SMTP client settings
            var smtpClient = new SmtpClient("smtp.example.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("your-email@example.com", "your-password");
            smtpClient.EnableSsl = true;

            // Compose the email message
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("your-email@example.com");
            mailMessage.To.Add(recipientEmail);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            // Send the email
            await smtpClient.SendMailAsync(mailMessage);
        }
    }

}
