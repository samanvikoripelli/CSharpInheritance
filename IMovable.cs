using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2
{
    interface IMovable
    {
        void Move();
    }
    class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine started.");
        }
    }
    class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving.");
        }
    }
}
