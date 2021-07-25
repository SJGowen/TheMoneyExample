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
            Assert.Equal(new Dollar(10), fiveXtwo);
            Dollar fiveXthree = five.Times(3);
            Assert.Equal(new Dollar(15), fiveXthree);
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
