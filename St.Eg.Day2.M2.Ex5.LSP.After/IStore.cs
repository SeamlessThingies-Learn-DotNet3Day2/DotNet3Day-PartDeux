using System;
using System.IO;

namespace St.Eg.Day2.M2.Ex5.LSP.After
{
    public interface IStore
    {
        void WriteAllText(int id, string message);

        Maybe<string> ReadAllText(int id);

        FileInfo GetFileInfo(int id);
    }
}
