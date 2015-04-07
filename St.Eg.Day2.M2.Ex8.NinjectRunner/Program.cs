using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using St.Eg.Day2.M2.Ex7.After;
using St.Eg.Day2.M2.Ex7.DIP.After;

namespace St.Eg.Day2.M2.Ex8.NinjectRunner
{
    public interface I_A
    {
        
    }

    public interface I_B
    {
        
    }

    public interface I_C
    {
        
    }

    public class Foo_A : I_A
    {
        public Foo_A(I_B b, I_C c)
        {
            
        }
    }

    public class Foo_B : I_B
    {
        
    }

    public class Foo_C : I_C
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            Example2();
        }
 
        private static void Example1()
        {
            // create a kernel
            var k = new StandardKernel();
            k.Bind<I_A>().To<Foo_A>();
            k.Bind<I_B>().To<Foo_B>();
            k.Bind<I_C>().To<Foo_C>();

            var a = k.Get<I_A>();
        }


        private static void Example2()
        {
            var di = new DirectoryInfo("c:\\");
            var k = new StandardKernel();
            k.Bind<IMessageStore>().To<MessageStore>();
            k.Bind<IStoreReader>().ToMethod(context => new FileStore(di));
            k.Bind<IStoreWriter>().ToMethod(context => new FileStore(di));
            k.Bind<IFileLocator>().ToMethod(context => new FileStore(di));


            var ms = k.Get<IMessageStore>();
        }
    }
}
