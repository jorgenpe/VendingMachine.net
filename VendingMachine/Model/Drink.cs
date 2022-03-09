using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
     class Drink : Product
    {
        private string beverageType;
        private string packageType;
        private string beverageName;
        private string beverageDescription;

        public string BeverageType { get { return beverageType; } set { beverageType = value; } }

        public string PackageType { get { return packageType; } set { packageType = value; } }

        public string BeverageName { get { return beverageName; } set { beverageName = value; } }

        public string BeverageDescription { get { return beverageDescription; } set { beverageDescription = value; } }

        public override string Examine()
        {
            return $"{BeverageType}: {PackageType}: {BeverageName}: {BeverageDescription}";
        }

        public override string Use()
        {
            if(packageType == "Bottle")
            {
                return $" Open the cap and you can now drink from the bottle.";
            }
            else { return $" Bend the opener to uprigth posion and then bend it back to original posion. You can now drink from the can."}
        }
    }
}
