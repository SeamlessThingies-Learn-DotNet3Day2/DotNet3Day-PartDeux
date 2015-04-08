using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace St.Eg.M2.Ex1c.INPC.Fody.After
{
    [ImplementPropertyChanged]
    public class Animal 
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal();
            var inpc = a as INotifyPropertyChanged;
            if (inpc != null) inpc.PropertyChanged += inpc_PropertyChanged;
            a.Age = 5;
            a.Name = "Bleu";
        }

        static void inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }
    }
}
