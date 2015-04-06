using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex1.INPC.After
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine(dog.Age);
            var inpc = dog as INotifyPropertyChanged;
            if (inpc != null) inpc.PropertyChanged += inpc_PropertyChanged;
            dog.Age = 10;
        }

        static void inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var a = sender as IAnimal;
            Console.WriteLine("{0} changed", e.PropertyName);
        }
    }

    public delegate void AgeUpdatedHandler(object sender, EventArgs args);

    public interface IAnimal
    {
        int Age { get; set; }
        void MakeSound();
        event AgeUpdatedHandler AgeUpdated;
    }


    public abstract class Animal : IAnimal, INotifyPropertyChanged
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (AgeUpdated != null) AgeUpdated(this, null);
                if (_age != value)
                {
                    _age = value;
                    if (PropertyChanged != null) 
                        PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        public event AgeUpdatedHandler AgeUpdated;

        public abstract void MakeSound();

        public event PropertyChangedEventHandler PropertyChanged;
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