using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public class LogSavingStoreWriter : IStoreWriter
    {
        public void Save(int id, string message)
        {
            Log.Information("Saving message {id}.", id);
        }
    }
}
