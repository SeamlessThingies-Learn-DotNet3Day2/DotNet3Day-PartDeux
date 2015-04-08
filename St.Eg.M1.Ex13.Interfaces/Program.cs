using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex3.Interfaces
{
    internal class Program
    {
        /*
         * 1. Copy the three classes from Ex2 (done)
         * 2. Create the IAnimal interface
         * 3. Derive Animal from IAnimal
         * 4. Create a method accepting an IAnimal
         * 5. In the method, calll MakeSound and print the age
         * 6. Create in Main a doc and cat object, and then 
         *    call the method twice, passing the cat and dog object in each call.
         *    */

        private static void Main(string[] args)
        {
            IAnimal d = new Dog(2);
            IAnimal c = new Cat(3);

            // TODO: add two calls to our new method
            d.MakeSound();
            c.MakeSound();
            Console.WriteLine("{0} {1}", d.Age, c.Age);

        }

        // TODO: create method accepting IAnimal, and call MakeSound and print age
        ///private static void doit(IAmimal animal)
        //{
            // TODO: call MakeSound and write Age
        //}
    }

    // TODO: create IAnimal Interface 

    // TODO: Derive Animal from IAnimal

    public interface IAnimal
    {
        int Age { get; set; }

        void MakeSound();
    }

    public abstract class Animal : IAnimal 
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

        public void Hello()
        {
            
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
