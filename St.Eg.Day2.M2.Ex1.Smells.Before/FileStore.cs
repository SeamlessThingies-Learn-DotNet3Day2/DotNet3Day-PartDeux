﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M2.Ex1.Smells.Before
{
    public class FileStore
    {
        public string WorkingDirectory { get; set; }

        public string Save(int id, string message)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            File.WriteAllText(path, message);
            return path;
        }

        public event EventHandler<MessageEventArgs> MessageRead;

        public void Read(int id)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            var msg = File.ReadAllText(path);
            MessageRead(this, new MessageEventArgs(msg));
        }
    }
}
