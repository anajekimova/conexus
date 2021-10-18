using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public static  void ChangeZeroPosition_Num_ExpectChangeZeroPosition()
        {
            int[] result = { 5, 0, 8, 3, 0 };
            int[] expect = { 5, 8, 3, 0, 0 };
            //int n = 5;

            //int[] arr = Program.PushZerosToEnd(result,  n);

            Assert.Equal(expect, result);

        }
    }
}
