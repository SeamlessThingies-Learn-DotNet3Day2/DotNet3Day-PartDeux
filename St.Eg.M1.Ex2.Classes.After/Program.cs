using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex2.Classes.After
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog(2);
            var c = new Cat(3);
            d.MakeSound();
            c.MakeSound();
            Console.WriteLine("{0} {1}", d.Age, c.Age);
        }

        public abstract class Animal
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
}
