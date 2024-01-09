using System;

namespace dotnet_lr2
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Rex");
            Man man = new Man("John", 20, dog);

            man.sayHi();
            dog.bark();

            man.getNewPet("Dog");

            Chihuahua chihuahua = new Chihuahua(10, "Chihuahua");
            chihuahua.bark();
            chihuahua.bite();

            man.getNewPet(chihuahua);
        }
    }
}