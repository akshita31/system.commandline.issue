using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;

namespace system.commandline_issue
{
    public static class DemoCommand
    {
        public static IReadOnlyCollection<ParseError> ParseUShort(string stringToParse)
        {
            var command = new RootCommand
            {
                new Option("--port") { Argument = new Argument<ushort>() }
            };

            // command.Handler = CommandHandler.Create(
            //     (bool aBool) => Console.WriteLine(aBool));

            return command.Parse(stringToParse).Errors;
        }
    }
}
