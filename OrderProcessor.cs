using System;
using System.Collections.Generic;
using System.Text;

namespace Real_Time_Order_Notification_System
{
    public delegate void OrderPlacedHandler(Order order);
    public class OrderProcessor
    {
        public event OrderPlacedHandler OnOrderPlaced;

        public void PlaceOrder(Order order)
        {
            try
            {
                Console.WriteLine($"Order Placed: {order.OrderId}");

                OnOrderPlaced?.Invoke(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
