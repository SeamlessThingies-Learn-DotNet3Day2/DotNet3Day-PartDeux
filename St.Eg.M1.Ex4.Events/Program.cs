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
         * 1. Copy classes and interface from Ex3 (already done)
         * 2. Create a delegate named AgeUpdatedHandler
         * 3. Add an event to the interface for the AgeUpdated delegate
         * 4. Implement the event in Animal
         * 5. Create a Dog object
         * 6. Subscribe to the AgeUpdated event
         * 7. Update the age of the dog
         * */

        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            Console.WriteLine(dog.Age);

            dog.Age = 1;

            dog.AgeUpdated += dog_AgeUpdated;
            dog.AgeUpdated += dog_AgeUpdated2;

            dog.Age = 3;
        }

        static void dog_AgeUpdated(object sender, EventArgs args)
        {
            var dog = sender as Dog;
            Console.WriteLine("Lets have a party!  My dog is now {0}", dog.Age);
            throw new Exception();
        }
        static void dog_AgeUpdated2(object sender, EventArgs args)
        {
            var dog = sender as Dog;
            if (dog.Age > 2)
            {
                Console.WriteLine("Now not a puppy {0}", dog.Age);
            }
        }
    }

    // TODO: declare event handler delegate
    public delegate void AgeUpdatedHandler(object sender, EventArgs args);

    public interface IAnimal
    {
        int Age { get; set; }
        void MakeSound();

        // TODO: declare event in interface
        event AgeUpdatedHandler AgeUpdated;
    }

    public abstract class Animal : IAnimal
    {
        // TODO: rewrite Age to send update notifications
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (AgeUpdated != null) AgeUpdated(this, new EventArgs());
            }
        }

        public abstract void MakeSound();

        public event AgeUpdatedHandler AgeUpdated;
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
