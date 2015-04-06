using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public interface IStoreWriter
    {
        void Save(int id, string message);
    }
}
