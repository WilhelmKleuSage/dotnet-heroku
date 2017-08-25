using FluentAssertions;
using Xunit;

namespace dotnet_heroku_tests
{
    public class AnotherTest
    {
        [Fact]
        public void ShouldPass()
        {
            false.Should().BeTrue();
        }
    }
}
