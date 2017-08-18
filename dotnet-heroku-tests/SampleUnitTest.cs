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

        [Fact]
        public void ShoulFail()
        {
            true.Should().BeFalse();
        }
    }
}
