using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model6
{
    public interface IRepository<T> where T : EntityBase
    {
        T Retrieve(string ID);
        void Save(T theItem);
    }
}
