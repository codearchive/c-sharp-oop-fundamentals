namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {
            
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (PurchasePrice == null) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Save the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order item

            return true;
        }
    }
}
