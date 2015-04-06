using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex3.Interfaces
{
    internal class Program
    {
        /*
         * 1. Copy the three classes from Ex2
         * 2. Create the IAnimal interface
         * 3. Derive Animal from IAnimal
         * 4. Create a method accepting an IAnimal
         * 5. In the method, calll MakeSound and print the age
         * 6. Create in Main a doc and cat object, and then 
         *    call the method twice, passing the cat and dog object in each call.
         *    */

        private static void Main(string[] args)
        {
            var d = new Dog(2);
            var c = new Cat(3);

            // TODO: add two calls to our new method

        }

        // TODO: create method accepting IAnimal, and call MakeSound and print age
        ///private static void doit(IAmimal animal)
        //{
            // TODO: call MakeSound and write Age
        //}
    }

    // TODO: create IAnimal Interface 

    // TODO: Derive Animal from IAnimal
    public abstract class Animal 
    {
        public int Age { get; set; }
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog()
        {

        }

        public Dog(int age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {

        }

        public Cat(int age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
