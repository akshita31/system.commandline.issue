using System;
using System.Linq;
using FluentAssertions;
using system.commandline_issue;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var errors = DemoCommand.ParseUShort("--port -9000");
            errors.First().Message.Should().Contain("--port");
        }
    }
}
