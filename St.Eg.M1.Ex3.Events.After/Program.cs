using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex4.Events.After
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine(dog.Age);

            // TODO: cast dog to INotifyPropertyChanged
            // TODO: if not null, += PropertChanged to call a method
            //if (inpc != null) inpc.PropertyChanged += // TODO: add method here
            dog.Age = 10; 
            dog.Age = 10;
        }

        // TODO: this is the event handler
        static void inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // TODO: print the property name that changed
        }

    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);
    public interface IAnimal
    {
        int Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }


    public abstract class Animal : IAnimal
    {
        private int _age;

        public int Age
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

