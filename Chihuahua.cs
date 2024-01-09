using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lr2
{
    internal class Chihuahua : Dog
    {
        int evilnessLevel;
        string name;

        public Chihuahua(int evilnessLevel, string name) : base(name)
        {
            this.evilnessLevel = evilnessLevel;
            this.name = name;
        }

        public void bite()
        {
            Console.WriteLine($"{name} bited human");
        }
    }
}
