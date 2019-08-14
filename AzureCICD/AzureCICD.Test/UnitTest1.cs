using AzureCICD.Controllers;
using Xunit;

namespace AzureCICD.Test
{
    public class UnitTest1
    {
        readonly ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetMyName()
        {
            var retrunValue = valuesController.Get(1);
            Assert.Equal("Narayana Nandyala", retrunValue.Value);
        }
    }
}
