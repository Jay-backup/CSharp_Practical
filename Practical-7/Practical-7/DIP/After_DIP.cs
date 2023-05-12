using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.DIP
{
    public interface INotificationService
    {
        void SendNotification(string strMessage);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string strMsg)
        {
            Console.WriteLine("Sending Email notification: {0}", strMsg);
        }
    }
    public class SMSNotificationService : INotificationService
    {
        public void SendNotification(string strMsg)
        {
            Console.WriteLine("Sending SMS notification: {0}", strMsg);
        }
    }
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string strMsg)
        {
            Console.WriteLine("Sending push notification: {0}", strMsg);
        }
    }

    public class NotificationSender
    {
        private readonly INotificationService notificationService;

        public NotificationSender(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void SendNotification(string strMsg)
        {
            notificationService.SendNotification(strMsg);
        }
    }
}
