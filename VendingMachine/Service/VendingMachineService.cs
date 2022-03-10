using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Service
{
    internal class VendingMachineService
    {
        private Product[] products = new Product[10];
        private int moneyInserted = 0;

        Product Purchase(int id) {

            for (int i = 0; i < products.Length; i++) 
            {
                if(products[i].Id == id && products[i].priceOfProduct <= moneyInserted)
                {
                    return products[i];
                }
            
            }
            
   
            
            return null; }


        List<string> ShowAll() { 
            
            List<string> list = new List<string>();
            foreach (Product product in products)
            {
                if
            }
            
            
            
            return null; }



        string Details(int id)
            {
                return null;    
            };
        void InsertMoney()
            {

            };
        Dictionary<int, int> EndTransactin() { return null; }

    }
}
