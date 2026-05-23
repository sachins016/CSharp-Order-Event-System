using System;
using System.Collections.Generic;
using System.Text;

namespace Real_Time_Order_Notification_System.Services
{
    public class LoggerService
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine("Order logged successfully");
        }
    }
}
