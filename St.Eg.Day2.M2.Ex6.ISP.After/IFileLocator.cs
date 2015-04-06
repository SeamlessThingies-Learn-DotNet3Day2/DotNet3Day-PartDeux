using System;
using System.IO;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public interface IFileLocator
    {
        FileInfo GetFileInfo(int id);
    }
}
