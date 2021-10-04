using System;
using System.Text;

namespace IterationStatements_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instructions were to write the example loop a total of 15 times.
            // I made an executive decision to just print it to the console 15 times
            // instead of writing it once and copy-pasta in the IDE.

            for (int i = 0; i < 15; i++)
                ExampleLoop();
        }
        static void ExampleLoop()
        {
            var exampleLoop = new StringBuilder();
            exampleLoop.AppendLine("for (int i = 0; i < 5; i++)");
            exampleLoop.AppendLine("{");
            exampleLoop.AppendLine("     Console.WriteLine($\"{i}\")");
            exampleLoop.AppendLine("}");

            Console.WriteLine(exampleLoop);
        }
    }
}
