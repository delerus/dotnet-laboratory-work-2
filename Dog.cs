using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lr2
{
    internal class Dog
    {
        string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public void bark()
        {
            Console.WriteLine($"{name}: bark bark!");
        }
    }
}
