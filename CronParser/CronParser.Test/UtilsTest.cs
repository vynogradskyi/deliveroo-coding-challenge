using System;
using Xunit;

namespace CronParser.Test
{
    public class UtilsTest
    {
        [Fact]
        public void makeResultForStar()
        {
            var actual = Utils.makeResult(0, 1, 7);
            var expected = "0 1 2 3 4 5 6 7";
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void makeResultForStarDividedBuyInt()
        {
            var actual = Utils.makeResult(0, 15, 59);
            var expected = "0 15 30 45";
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void parseRegularForOneValue()
        {
            var actual = Utils.parseRegular("15", 59);
            var expected = "15";
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void parseRegularForCommaSeparated()
        {
            var actual = Utils.parseRegular("15,30,45", 59);
            var expected = "15 30 45";
            Assert.Equal(actual, expected);
        }



        [Fact]
        public void parseRegularForStar()
        {
            var actual = Utils.parseRegular("*", 10);
            var expected = "0 1 2 3 4 5 6 7 8 9 10";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void parseRegularForStarDividedBySix()
        {
            var actual = Utils.parseRegular("*/6", 23);
            var expected = "0 6 12 18";
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void parseRegularForDashSeparatedValues()
        {
            var actual = Utils.parseRegular("14-23", 23);
            var expected = "14 15 16 17 18 19 20 21 22 23";
            Assert.Equal(actual, expected);
        }
    }
}
