﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Core;
using Serilog.Events;

namespace St.Eg.Day2.M2.Ex6.ISP.After
{
    public class SpySink : ILogEventSink
    {
        private readonly BlockingCollection<LogEvent> events;

        public SpySink()
        {
            this.events = new BlockingCollection<LogEvent>();
        }

        public void Emit(LogEvent logEvent)
        {
            this.events.Add(logEvent);
        }

        public IEnumerable<LogEvent> Events
        {
            get { return this.events; }
        }
    }
}
