using CSharpTask;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestCSharpTask
{
    public class UnitTest1
    {
        public static IEnumerable<object[]>ListWithNumber()
        {
            yield return new object[]
            {
                new List<int>{5, 8, 3, 0, 0 }
            };
        }

        [Theory]
        [MemberData(nameof(ListWithNumber))]
        public void PushedZeroToEnd_ListArr_ExpectPushedZeroToEnd(List<int>arr)
        {
            var expect = new List<int> { 5, 8, 3, 0, 0 };

            var result = HomeTask.ZeroToEnd(arr);

            Assert.Equal(expect, result);
        }

    }
}
