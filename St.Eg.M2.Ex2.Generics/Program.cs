using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex2.Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: create a dog with Age of type double
            // TODO: create a cat with Age of type int
            var dog = new Dog<float>();
            //var cat = new Cat<>();

            // TODO: output the age of each
            Console.WriteLine(dog.Age);
            //Console.WriteLine(cat.Age);

            // TODO: print the types of Age for cat and dog
            Console.WriteLine(dog.Age.GetType().Name);
            //Console.WriteLine(cat.Age.GetType().Name);
        }
    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);

    
    // TODO: Make this a generic interface
    public interface IAnimal<T>
    {
        // TODO: change this type to the generic type
        T Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }
    

    
    // TODO: make this generic too, class name and the IAnimal derivation
    public abstract class Animal<T> : IAnimal<T>
    {
        // TODO: must change to generic type
        private T _age;

        // TODO: must change to generic type
        public T Age
        {
            get { return _age; }
            set
            {
                //if (AgeUpdated != null) AgeUpdated(this, null);
                //if (_age != value)
                ///{
                    _age = value;
                //}
            }
        }

        public event AgeUpdatedHandler AgeUpdated;

        public abstract void MakeSound();

        //public event PropertyChangedEventHandler PropertyChanged;
    }
     
    
    // TODO: Derive from generic Animal
    public class Dog<T> : Animal<T>
    {
        public Dog()
        {

        }

        // TODO: change the type to the generic type
        public Dog(T age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
     

    /*
    // TODO: Derive from generic Animal
    public class Cat<> : Animal<>
    {
        public Cat()
        {

        }

        // TODO: change to generic types
        public Cat(int age)
        {
            Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
     * */
}
     
