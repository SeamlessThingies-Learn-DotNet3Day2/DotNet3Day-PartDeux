using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex2.Generics.After
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: create a dog with AGe of type double
            // TODO: create a cat with Age of type int
            var dog = new Dog<int>(5);
            var cat = new Cat<double>(10.0);

            // TODO: output the age of each
            Console.WriteLine(dog.Age);
            Console.WriteLine(cat.Age);

            // TODO: print the types of Age for cat and dog
            Console.WriteLine(dog.Age.GetType().Name);
            Console.WriteLine(cat.Age.GetType().Name);
        }
    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);
    
    // TODO: Make this a generic interface
    public interface IAnimal<T>
    {
        T Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }


    // TODO: make this generic too
    public abstract class Animal<T> 
    {
        // TODO: change the type to the generic type
        private T _age;

        // TODO: change the type to the generic type
        public T Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (AgeUpdated != null) AgeUpdated(this, null);

                // TODO: modify to fire PropertyChanged
            }
        }

        public event AgeUpdatedHandler AgeUpdated;

        // TODO: Add an event for PropertyChanged

        public abstract void MakeSound();
    }

    // TODO: Derive from generic
    public class Dog<T> : Animal<T>
    {
        public Dog()
        {

        }

        public Dog(T age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    // TODO: Derive from generic
    public class Cat<T> : Animal<T>
    {
        public Cat()
        {

        }

        public Cat(T age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
