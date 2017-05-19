using System;
using Xunit;

namespace lets_code_ci_tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(1, 2);
        }
    }
}
