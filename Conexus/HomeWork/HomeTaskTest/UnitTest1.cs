using CSharpTask;
using System.Collections.Generic;
using Xunit;

namespace HomeTaskTest
{
    public class UnitTest1
    {

        [Fact]
        public void PushedZeroToEnd_Arr_ExpectPushedZeroToEnd()
        {
            var expect = new List<int> { 5, 8, 3, 0, 0 };

            List<int> arr = new List<int> { 5, 0, 8, 3, 0 };

            var result = HomeTask.ZeroToEnd(arr);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void FindMindian_Arr_ExpectFindMedian ()
        {
            var expect = 30.5;

            List<int> arr = new List<int> { 13, 25, 36, 1, 46, 87 };

            var result = HomeTask.FindMedian(arr);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void ChecTrueOrFalse_Number_ExpectTrue()
        {
            var expect = true;

            var x = 1;

            var result = HomeTask.CheckNumber(x);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void ChecFalse_Number_ExpectFalse()
        {
            var expect = false;

            var x = 4;

            var result = HomeTask.CheckNumber(x);

            Assert.Equal(expect, result);
        }
    }
}
