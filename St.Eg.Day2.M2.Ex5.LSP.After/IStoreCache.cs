using System;
namespace St.Eg.Day2.M2.Ex5.LSP.After
{
    public interface IStoreCache
    {
        void AddOrUpdate(int id, string message);

        Maybe<string> GetOrAdd(int id, Func<int, Maybe<string>> messageFactory);
    }
}
