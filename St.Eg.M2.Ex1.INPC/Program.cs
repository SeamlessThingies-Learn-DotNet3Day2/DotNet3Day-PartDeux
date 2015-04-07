using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex1.INPC
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create instance of an animal
            // TODO: case the animal to INotifyPropertyChanged
            // TODO: subscript to INPC changed with an event handler
            // TODO: in the handler print the name of the property that changed
        }
    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);
    public interface IAnimal
    {
        int Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }


    // TODO: Change to inplement INotifyPropertyChanged
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
