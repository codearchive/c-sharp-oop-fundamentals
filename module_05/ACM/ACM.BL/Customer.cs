﻿using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer

            return new Customer();
        }

        /// <summary>
        /// Retrieve all of the customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();
        }

        /// <summary>
        /// Save the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }
    }
}
