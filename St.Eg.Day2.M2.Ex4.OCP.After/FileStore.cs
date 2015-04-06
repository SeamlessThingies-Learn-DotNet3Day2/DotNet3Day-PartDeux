using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M2.Ex4.OCP.After
{
    public class FileStore
    {
        public virtual void WriteAllText(string path, string message)
        {
            File.WriteAllText(path, message);
        }

        public virtual string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public virtual FileInfo GetFileInfo(int id, string workingDirectory)
        {
            return new FileInfo(
                Path.Combine(workingDirectory, id + ".txt"));
        }
    }
}
