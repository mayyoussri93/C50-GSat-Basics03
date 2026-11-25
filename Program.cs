using System.Security.Cryptography;
using System.Threading.Channels;

namespace C50_GSat_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            // both title and upperTitle to show that title did not change
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Original: {title}");
            Console.WriteLine($"Uppercase: {upperTitle}");
        }
    }
}
