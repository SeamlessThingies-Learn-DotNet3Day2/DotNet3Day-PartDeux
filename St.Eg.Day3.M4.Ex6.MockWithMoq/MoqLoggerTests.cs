using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace St.Eg.Day3.M4.Ex6.MockWithMoq
{
    #region reference 
    public interface ILog
    {
        void WriteToLog(string message);
    }
    /*
    public class Log : ILog
    {
        public void WriteToLog(string message)
        {
        }
    }
    */
    public class LogGenerator
    {
        private readonly ILog log;

        public LogGenerator(ILog log)
        {
            this.log = log;
        }

        public void Foo()
        {
            this.log.WriteToLog("my log message");
        }
    }

    public class MoqLoggerTests
    {
        /*
        [Fact]
        public void FooLogsCorrectly()
        {
            // Arrange
            var logMock = new Mock<ILog>();
            var logGenerator = new LogGenerator(logMock.Object);

            // Act
            logGenerator.Foo();

            // Assert
            logMock.Verify(m => m.WriteToLog("my log message"));
        }
         * */
    }

    #endregion
}
