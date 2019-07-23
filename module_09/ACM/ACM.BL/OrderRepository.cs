using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined order

            // Temporary hard-coded values to return
            // a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 1, 10, DateTime.Now.Hour, 30, 20, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // Code that saves the defined order

            return true;
        }

    }
}
