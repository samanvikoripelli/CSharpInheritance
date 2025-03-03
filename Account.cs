using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2
{
    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a general account.");
        }
    }
    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a savings account.");
        }
    }
}
