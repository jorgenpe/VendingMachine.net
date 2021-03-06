using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine.Model
{
    abstract class Product
    {
        public readonly int id;
        public static readonly int[] currencyOptions = {1, 5, 10, 20, 50, 100, 200, 500, 1000 };
        public int priceOfProduct;

        

        /*protected Product(int id, int priceOfProduct)
        {
            this.id = id;
            this.priceOfProduct = priceOfProduct;
        }*/
        
        public int Id { get { return id; } }

        public int[] CurrencyOption { get { return currencyOptions; }  }

        public int PriceOfProduct { get { return priceOfProduct; } set { this.priceOfProduct = value; } }

        public abstract string Examine();
        public abstract string Use();
    }
}
