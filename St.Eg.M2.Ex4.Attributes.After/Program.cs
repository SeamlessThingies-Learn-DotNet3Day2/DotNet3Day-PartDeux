using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace St.Eg.M2.Ex5.Attributes.After
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyAttribute : Attribute
    {
        public string Data { get; set; }
        public MyAttribute(string data)
        {
            Data = data;
        }
    }

    public class Foo
    {
        [My("Heres some data")]
        public string Bar { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var f = new Foo();
            var t = f.GetType();
            t = null;
        }
    }
}
