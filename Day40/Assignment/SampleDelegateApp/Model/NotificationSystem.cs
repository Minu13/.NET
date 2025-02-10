using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDelegateApp.Model
{
    public delegate void NotificationHandler(string message);
    public class NotificationSystem
    {
        private List<NotificationHandler> subscribers = new List<NotificationHandler>();

        public void subscribe(NotificationHandler subscriber)
        {

            subscribers.Add(subscriber);
        }
        public void unsubscribe(NotificationHandler subscriber)
        {

            subscribers.Remove(subscriber);
        }

        public void SendNotification(string message)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber(message);
            }
        }
    }
}
