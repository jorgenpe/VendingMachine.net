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

        public string CandyType { get { return candyType; } set { candyType = value; } }   

        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
