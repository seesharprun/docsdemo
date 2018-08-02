using System;
using Humanizer;

namespace RVNUG
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeTill2019 = new DateTime(2019, 01, 01).Humanize();
            Console.WriteLine(timeTill2019);
        }
    }
}
