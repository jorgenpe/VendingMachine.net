using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine.Model
{
     class Candy : Product
    {
        private string candyType;
        private string candyName;
        private string candyDescription;
        

        public string CandyType { get { return candyType; } set { candyType = value; } }
        
        public string CandyName { get { return candyName; } set { candyName = value; } }

        public string CandyDescription { get { return candyDescription; } set { candyDescription = value; } }

        public override string Examine()
        {
            return $"{CandyType}: {CandyName}: {CandyDescription}";
        }

        public override string Use()
        {
            return $"Open the rapper and eat your candy";
        }
    }
}
