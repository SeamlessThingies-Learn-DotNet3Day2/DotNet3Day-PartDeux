using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace St.Eg.Day3.M4.Ex2.Theories
{
    public class TheoryTests
    {
        #region reference
        /*
        private readonly ITestOutputHelper output;

        public TheoryTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [Theory]
        public void MyFirstTheoryInline(int value)
        {
            output.WriteLine("{0}", value);
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
         * 
         * */
        #endregion
    }
}
