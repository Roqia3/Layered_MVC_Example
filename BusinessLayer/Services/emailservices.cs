namespace MVC_Example.BusinessLayer.Services.Email
{
    public interface IEmailService
    {
        Task SendEmail(string recipientEmail, string subject, string body);
    }
}
