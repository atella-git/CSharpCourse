using System;
using System.Collections.Generic;
using System.Text;

namespace _01Assignment
{
    class PurchasePrice
    {
        private decimal priceofsoda;

         public PurchasePrice()
        {

        }

        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }
        public PurchasePrice(decimal initialPrice)
        {
            Priceofsodadec = initialPrice;
        }

        public int Price
        {
            get 
            {
                return (int) priceofsoda*100;
            }
            set
            {
                priceofsoda = value/100;
            }
        }

        public decimal Priceofsodadec
        {
            get
            {
                return priceofsoda;
            }
            set
            {
                priceofsoda = value;
            }
        }

    }
}
