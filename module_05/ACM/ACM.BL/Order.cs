using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }
    }
}
