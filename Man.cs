using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lr2
{
    internal class Man
    {
        string name;
        int age;
        Dog pet;

        public Man(string name, int age, Dog pet)
        {
            this.name = name;
            this.age = age;
            this.pet = pet;
        }

        public void sayHi()
        {
            Console.WriteLine($"{name}: hi!");
        }

        public void getNewPet(string petName)
        {
            pet = new Dog(petName);
        }

        public void getNewPet(Dog dog)
        {
            pet = dog;
        }


    }
}
