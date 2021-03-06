﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M2.Ex5.LSP.After
{
    public class StoreCache : IStoreCache
    {
        private readonly ConcurrentDictionary<int, Maybe<string>> cache;

        public StoreCache()
        {
            this.cache = new ConcurrentDictionary<int, Maybe<string>>();
        }

        public virtual void AddOrUpdate(int id, string message)
        {
            var m = new Maybe<string>(message);
            this.cache.AddOrUpdate(id, m, (i, s) => m);
        }

        public virtual Maybe<string> GetOrAdd(int id, Func<int, Maybe<string>> messageFactory)
        {
            return this.cache.GetOrAdd(id, messageFactory);
        }
    }
}
