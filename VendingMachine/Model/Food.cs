using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
     class Food : Product
    {
        private string foodType;
        public string foodName;
        public string foodDescription;

        public string Foodtype { get { return foodType; } set { foodType = value; } }

        public string FoodName { get{ return foodName; } set { foodName = value; } }

        public string FoodDescription { get { return foodDescription; } set { foodDescription = value; } }

        public override string Examine()
        {
            return $" {Foodtype}: {FoodName}: {FoodDescription} ";
        }

        public override string Use()
        {
            if(foodType == "Sandwich")
            {
                return $" Unrapp the sandwich and eat it";
            } else
            {
                return $" Remove the lid and take the fork and knife and start to eat."
            }
            
        }
    }
}
