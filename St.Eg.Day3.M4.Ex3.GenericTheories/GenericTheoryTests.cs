using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace St.Eg.Day3.M4.Ex3.GenericTheories
{
    public class GenericTheoryTests
    {
        [Theory]
        [InlineData(42)]
        [InlineData(21.12)]
        [InlineData("Hello, world!")]
        public void GenericTestMethod<T>(T value)
        {
            Assert.True(true);
        }
    }
}
