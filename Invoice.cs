using System;
using System.Collections.Generic;
using System.Text;

namespace Mausbach_Project3
{
    class Invoice
    {
        public string partNumber { get; set; } //auto-implement property
        public string partDescription { get; set; } //auto-implement property

        public int quantity = 0; //property declaration
        public decimal pricePerItem = 0.00M; //property declaration
        public decimal totalInvoiceAmount = 0;


        //property to get and set quantity instance variables
        public int Quantity
        {
            get //returns instance variable value
            {
                return quantity;
            }
            set //assigns a new value to corresponding instance variable
            {
                if (value > 0) // validation
                {  
                    quantity = value;
                }
               
            }
        }

        //property to get and set quantity instance variables
        public decimal PricePerItem
        {
            get //returns instance variable value
            {
                return pricePerItem;
            }
            set //assigns a new value to corresponding instance variable
            {
                if (value > 0.00M) // validation
                    {
                    pricePerItem = value; 
                    }
                    
            }
        }

        //Invoice constructor that recieves parameters
        public Invoice(string partNumber1, string partDescription1, int quantity1, decimal pricePerItem1)
        {
            partNumber = partNumber1;
            partDescription = partDescription1;
            //validate quantity
            if (quantity1 > 0)
                {
                quantity = quantity1;
                }
            //validate pricePerItem
            if (pricePerItem1 > 0)
                {
                pricePerItem = pricePerItem1;
                }
        }

         public decimal GetInvoiceAmount(int quantity, decimal pricePerItem)
            {
            totalInvoiceAmount = quantity * pricePerItem;
            return totalInvoiceAmount;
            }
            
    }
}
