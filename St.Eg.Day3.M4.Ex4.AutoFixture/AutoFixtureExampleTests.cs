using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Xunit;
using Xunit.Extensions;

namespace St.Eg.Day3.M4.Ex4.AutoFixture
{
    #region reference
    #region sut

    public class Foo
    {
        public int Echo(int value)
        {
            return value;
        }

        public void Echo2()
        {
            
        }
    }

    #endregion

    public class AutoFixtureExampleTests
    {
        /*
        [Fact]
        public void JustAFact()
        {
            var foo = new Foo();
            var result = foo.Echo(1);
            Assert.Equal(result, 1);
        }

        [Theory]
        [InlineData(1)]
        public void DataDrivenTheory(int expectedValue)
        {
            var foo = new Foo();
            var result = foo.Echo(expectedValue);
            Assert.Equal(result, expectedValue);
        }

        [Fact]
        public void BasicAutoFixtureTest()
        {
            var sut = new Foo();
            var fixture = new Fixture();
            var expectedNumber = fixture.Create<int>();
            Assert.Equal(expectedNumber, sut.Echo(expectedNumber));
        }
         * */
    }
    #endregion
}
