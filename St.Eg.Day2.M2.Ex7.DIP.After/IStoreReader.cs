using System;

namespace St.Eg.Day2.M2.Ex7.After
{
    public interface IStoreReader
    {
        Maybe<string> Read(int id);
    }
}
