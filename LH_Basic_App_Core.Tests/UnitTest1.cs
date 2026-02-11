using LH_Basic_App_GitHub;
using Xunit;

namespace LH_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 tp = new Class1();

            var result = tp.Name;

            Assert.Equal("[Luke Hankins] - The Code Master", result);
        }
    }
}