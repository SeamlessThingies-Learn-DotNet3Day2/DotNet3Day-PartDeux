using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex4.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            array();
            list();
            dict();
        }

        private static void array()
        {
            /*
            // TODO: create an array of IAnimal<int>
            var animals = 
            {
                new Dog<int>(5),
                new Cat<int>(5)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine("I am a {0} and I'm this old {1}", animal.GetType().Name, animal.Age);
            }
             * */
        }

        private static void list()
        {
            // TODO: create an emply list of IAnimal<int>
            //var animals = 

            // TODO: add two animals
            //animals.Add(new Dog<int>(5));
            //animals.Add(new Cat<int>(5));

            /*
            foreach (var animal in animals)
            {
                Console.WriteLine("I am a {0} and I'm this old {1}", animal.GetType().Name, animal.Age);
            }
             * */
        }

        private static void dict()
        {
            // TODO: create a dictionary of IAnimal<int>
            //var animals = 

            // TODO: add two animals
            //animals["Bleu"] = new Dog<int>(1);
            //animals["Bob"] = new Cat<int>(10);
            /*
            foreach (var animal in animals.Values)
            {
                Console.WriteLine("I am a {0} and I'm this old {1}", animal.GetType().Name, animal.Age);
            }
             * */
        }
    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);

    public interface IAnimal<T>
    {
        T Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }


    public abstract class Animal<T> : IAnimal<T>
    {
        private T _age;

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

        public abstract void MakeSound();
    }

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
