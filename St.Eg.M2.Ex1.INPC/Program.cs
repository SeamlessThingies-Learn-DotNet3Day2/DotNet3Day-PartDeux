using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex1.INPC
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create instance of an animal
            // TODO: cast the animal to INotifyPropertyChanged
            // TODO: subscribe to INPC changed with an event handler
            // TODO: in the handler print the name of the property that changed

            var dog = new Dog();

            var inpc = dog as INotifyPropertyChanged;
            if (inpc != null)
            {
                inpc.PropertyChanged += inpc_PropertyChanged;
            }
            var inpchanging = dog as INotifyPropertyChanging;
            if (inpchanging != null) inpchanging.PropertyChanging += inpchanging_PropertyChanging;

            dog.Age = 5;
            dog.Name = "Bleu";

            Console.ReadLine();
        }

        static void inpchanging_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            var animal = sender as IAnimal;
            Console.WriteLine("The following property is going to change: {0} from: {1}", e.PropertyName, animal.Age);

            switch (e.PropertyName)
            {
                case "Name":
                    break;
                case "Age":
                    break;
            }
        }

        static void inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var animal = sender as IAnimal;
            Console.WriteLine("The following property has changed: {0} to: {1}", e.PropertyName, animal.Age);
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
    public abstract class Animal : IAnimal, INotifyPropertyChanged,
        INotifyPropertyChanging

    {
        protected bool SetField<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {

            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }

            OnPropertyChanging(propertyName);

            field = newValue;

            OnPropertyChanged(propertyName);

            return true;

        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanging != null) PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        private void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                SetField(ref _age, value);
                //_age = value;

                //if (AgeUpdated != null) AgeUpdated(this, null);

                // TODO: modify to fire PropertyChanged
                //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (PropertyChanging != null) PropertyChanging(this, new PropertyChangingEventArgs("Name"));

                _name = value;

                // TODO: modify to fire PropertyChanged
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event AgeUpdatedHandler AgeUpdated;

        // TODO: Add an event for PropertyChanged

        public abstract void MakeSound();

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;
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
