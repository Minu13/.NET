using SampleDelegateApp.Model;

namespace SampleDelegateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notificationSystem = new NotificationSystem();

            var user1 = new User("Maya");
            var user2 = new User("Minu");

            notificationSystem.subscribe(user1.ReceiveNotifiation);
            notificationSystem.subscribe(user2.ReceiveNotifiation);

            notificationSystem.SendNotification("New event happening soon");

            notificationSystem.unsubscribe(user2.ReceiveNotifiation);
            notificationSystem.SendNotification("Event postponed");

        }

        public static void PrintMessage(string name, string message)
        {
            Console.WriteLine($"{name} {message}");
        }

    }
}
