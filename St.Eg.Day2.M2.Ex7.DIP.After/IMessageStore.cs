using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using St.Eg.Day2.M2.Ex7.After;

namespace St.Eg.Day2.M2.Ex7.DIP.After
{

    public interface IMessageStore
    {
        void Save(int id, string message);

        Maybe<string> Read(int id);

        FileInfo GetFileInfo(int id);
    }
}
