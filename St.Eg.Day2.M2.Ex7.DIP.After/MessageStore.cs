using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using St.Eg.Day2.M2.Ex7.DIP.After;

namespace St.Eg.Day2.M2.Ex7.After
{
    public class MessageStore : IMessageStore 
    {
        private readonly IFileLocator fileLocator;
        private readonly IStoreWriter writer;
        private readonly IStoreReader reader;

        public MessageStore(
            IStoreWriter writer,
            IStoreReader reader,
            IFileLocator fileLocator)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            if (reader == null)
                throw new ArgumentNullException("reader");
            if (fileLocator == null)
                throw new ArgumentNullException("fileLocator");

            this.fileLocator = fileLocator;
            this.writer = writer;
            this.reader = reader;
        }

        public void Save(int id, string message)
        {
            this.writer.Save(id, message);
        }

        public Maybe<string> Read(int id)
        {
            return this.reader.Read(id);
        }

        public FileInfo GetFileInfo(int id)
        {
            return this.fileLocator.GetFileInfo(id);
        }
    }

}
