using System;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedCodeExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Example of using StringBuilder for efficient string manipulation
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");
            builder.Append(" ");
            builder.Append("World!");
            Console.WriteLine(builder.ToString());

            // Example of asynchronous programming
            await PerformAsyncOperation();
        }

        static async Task PerformAsyncOperation()
        {
            // Your asynchronous code here
        }
    }
}
