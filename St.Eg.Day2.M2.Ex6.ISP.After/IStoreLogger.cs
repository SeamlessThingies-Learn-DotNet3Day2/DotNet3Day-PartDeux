using System;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public interface IStoreLogger
    {
        void Saving(int id, string message);

        void Saved(int id, string message);

        void Reading(int id);

        void DidNotFind(int id);

        void Returning(int id);
    }
}
