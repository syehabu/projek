using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Class_Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says: Meog-meong");
        }
    }
}

