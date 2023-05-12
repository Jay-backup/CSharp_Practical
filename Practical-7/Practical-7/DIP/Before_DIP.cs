using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.DIP
{
    class EmailNotification
    {
        public void SendNotification(string message)
        {
            // Send email notification
        }
    }
    class SmsNotification
    {
        public void SendNotification(string message)
        {
            // Send email notification
        }
    }
    class PushNotification
    {
        public void SendNotification(string message)
        {
            // Send email notification
        }
    }
    public class NotificationService
    {
        private EmailNotification emailNotification;
        private SmsNotification smsNotification;
        private PushNotification pushNotification;

        public NotificationService()
        {
            emailNotification = new EmailNotification(); // Violation of DIP
            smsNotification = new SmsNotification(); // Violation of DIP
            pushNotification = new PushNotification(); // Violation of DIP
        }

        public void SendNotification(string message)
        {
            emailNotification.SendNotification(message); // Violation of DIP
            smsNotification.SendNotification(message); // Violation of DIP
            pushNotification.SendNotification(message); // Violation of DIP
        }
    }
}
