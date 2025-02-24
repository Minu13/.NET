namespace ServicesAndDIApp.Services
{
    public interface IRRdEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
