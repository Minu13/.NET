namespace ServicesAndDIApp.Services
{
    public class TwilioEmailService : IRRdEmailService
    {
        public TwilioEmailService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TwilioEmailServcie created");
            Console.ResetColor();

        }
        public Task SendEmailAsync(string to, string subject, string body)
        {
            return Task.Run(() =>
            {
                //real api call to twilios
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Sending Email via Twilio service to user {to}  subject {subject} body {body}");
                Console.ResetColor();
            });

        }
    }
}