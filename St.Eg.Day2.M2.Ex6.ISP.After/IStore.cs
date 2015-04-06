using System;
using System.IO;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public interface IStore
    {
        void Save(int id, string message);

        Maybe<string> ReadAllText(int id);
    }
}
