﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public class SqlStore : IStore
    {
        public void Save(int id, string message)
        {
            // Write to database here
        }

        public Maybe<string> ReadAllText(int id)
        {
            // Read from database here
            return new Maybe<string>();
        }
    }
}
