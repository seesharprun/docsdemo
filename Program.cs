using System;
using System.Threading.Tasks;
using Humanizer;

namespace RVNUG
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("This is awesome sauce!");
        }
    }
}
