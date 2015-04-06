using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP
{
    public static class Assert
    {
        public static void AreEqual(object o1, object o2)
        {
            if (o1 != o2) throw new Exception("Values are not equal");
        }
    }
}
