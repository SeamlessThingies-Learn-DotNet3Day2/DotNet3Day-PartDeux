using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex4.Events
{
    class Program
    {
        /* 
         * 1. Copy classes and interface from Ex3
         * 2. Create a delegate named AgeUpdatedHandler
         * 3. Add an event to the interface for the AgeUpdated delegate
         * 4. Implement the event in Animal
         * 5. Create a Dog object
         * 6. Subscribe to the AgeUpdated event
         * 7. Update the age of the dog
         * */

        static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine(dog.Age);

            // TODO: add event handler for dog
            // TODO: update the age
        }
    }

    // TODO: declare event handler delegate
    public delegate void AgeUpdatedHandler(object sender, EventArgs args);

    public interface IAnimal
    {
        int Age { get; set; }
        void MakeSound();

        // TODO: declare event in interface
    }

    public abstract class Animal : IAnimal
    {
        // TODO: rewrite Age to send update notifications
        public int Age { get; set; }

        public event AgeUpdatedHandler AgeUpdated;

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
