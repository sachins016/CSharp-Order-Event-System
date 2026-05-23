using Real_Time_Order_Notification_System;
using Real_Time_Order_Notification_System.Services;
using System;

namespace Real_Time_Order_Notification_System.Services
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create processor
            OrderProcessor processor = new OrderProcessor();

            // Create services
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            // Subscribe methods to event
            processor.OnOrderPlaced += emailService.SendEmail;
            processor.OnOrderPlaced += smsService.SendSMS;
            processor.OnOrderPlaced += loggerService.LogOrder;

            // Create order
            Order order = new Order
            {
                OrderId = 101,
                CustomerName = "Soorya",
                Amount = 2500
            };

            // Place order
            processor.PlaceOrder(order);

            Console.ReadLine();
        }
    }
}
