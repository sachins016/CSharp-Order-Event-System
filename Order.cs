using System;
using System.Collections.Generic;
using System.Text;

namespace Real_Time_Order_Notification_System
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
    }
}
