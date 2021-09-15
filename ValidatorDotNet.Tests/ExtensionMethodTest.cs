using Raccoon.Ninja.ValidatorDotNet.ExtensionMethods;
using Xunit;

namespace Raccoon.Ninja.ValidatorDotNet.Tests
{
    public class ExtensionMethodTest
    {
        [Fact]
        public void IsNumeric_NotANumber()
        {
            Assert.False(true.IsNumeric());
        }
        
        [Fact]
        public void IsNumeric_IsANumber()
        {
            Assert.True(12.IsNumeric());
        }
    }
}