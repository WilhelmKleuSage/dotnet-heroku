using System;
using FluentAssertions;
using Xunit;

namespace dotnet_heroku_tests
{
    public class SampleUnitTest
    {
        [Fact]
        public void ShouldPass()
        {
            true.Should().BeTrue();
        }
    }
}
