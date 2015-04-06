using System;
namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public interface IStoreCache
    {
        void Save(int id, string message);

        Maybe<string> GetOrAdd(int id, Func<int, Maybe<string>> messageFactory);
    }
}
