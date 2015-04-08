using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex5.InterfaceBasedPolymorphism
{
    public interface ILogger {
        void LogThisMessage();
    }

    public class FileLogger : ILogger {
        public void LogThisMessage() {
            // write to a file
        }
    }

    public class DataBaseLogger : ILogger {
        public void LogThisMessage() {
            // write to database
        }
    }

    public class AComponentThatNeedsLogging {
        public ILogger LoggerToUse { get; set; }
    }

    public class ComponentFactory {
        private Dictionary<int, Func<ILogger>> _loggerFactories =
            new Dictionary<int, Func<ILogger>>() {
                {0, () => new FileLogger()},
                {1, () => new DataBaseLogger()},
            };

        public AComponentThatNeedsLogging buildComponent() {
            var component = new AComponentThatNeedsLogging();

            // read type of logger from config and inject 
            // proper logger
            var loggerToUse = 0;
            component.LoggerToUse = _loggerFactories[loggerToUse]();

            return component;
        }
    }
}
