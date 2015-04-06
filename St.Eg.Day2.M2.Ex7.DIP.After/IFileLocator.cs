using System;
using System.IO;

namespace St.Eg.Day2.M2.Ex7.After
{
    public interface IFileLocator
    {
        FileInfo GetFileInfo(int id);
    }
}
