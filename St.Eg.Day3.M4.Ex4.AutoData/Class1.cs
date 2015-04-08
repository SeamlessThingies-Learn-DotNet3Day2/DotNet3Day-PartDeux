using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace St.Eg.Day3.M4.Ex4.AutoData
{
    public class AutoDataTests
    {
        [Theory, AutoData]
        public void AutoDataTheoryTest(int a, int b)
        {
            
        }
    }
}
