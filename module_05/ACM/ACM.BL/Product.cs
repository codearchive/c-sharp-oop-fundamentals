namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }

        /// <summary>
        /// Save the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }
    }
}

/*Product
 * product name
 * description
 * current price
 * Validate()
 * Retrieve()
 * Save()
 *
 *
 *
 *Order
 *Validate()
 * Retrieve()
 * Save()
 *
 *
 *Order Item
 * Product
 * Quantity
 * Purchase price
  *Validate()
 * Retrieve()
 * Save()
 */
