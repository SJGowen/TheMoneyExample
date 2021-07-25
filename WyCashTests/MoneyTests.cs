using System;
using WyCash;
using Xunit;

namespace WyCashTests
{
    public class MoneyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar fiveXtwo = five.Times(2);
            Assert.Equal(10, fiveXtwo.Amount);
            Dollar fiveXthree = five.Times(3);
            Assert.Equal(15, fiveXthree.Amount);
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
        }
    }
}
