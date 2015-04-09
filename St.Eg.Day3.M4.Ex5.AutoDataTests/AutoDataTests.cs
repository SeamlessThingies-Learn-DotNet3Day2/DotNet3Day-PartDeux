using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace St.Eg.Day3.M4.Ex5.AutoDataTests
{
    #region reference 
    public class AutoDataTestExamples
    {
        public class Foo
        {
            public double Value { get; set; }
            public string Text { get; set; }

            public double multiply(double by)
            {
                return Value*by;
            }
        }
        /*
        [Theory, AutoData]
        public void SimpleAutoDataTest(double multiplier)
        {
            var sut = new Foo() {Value = 5};
            var result = sut.multiply(multiplier);

            Assert.Equal(result, sut.Value * multiplier);
        }

        [Theory, AutoData]
        public void ComplexAutoDataTest(Foo sut, double value, double multiplier)
        {
            sut.Value = value;
            var result = sut.multiply(multiplier);

            Assert.Equal(result, value * multiplier);
        }
         * */
    }
    #endregion
}
