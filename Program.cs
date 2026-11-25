using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace C50_GSat_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            // both title and upperTitle to show that title did not change
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"Original: {title}");
            //Console.WriteLine($"Uppercase: {upperTitle}");

            //Q2.Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine($"ReferenceEquals: {ReferenceEquals(str1, str2)}");

            //Q3.Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            // object.Print the final result.
            StringBuilder textStr = new StringBuilder();
            textStr.Append("Book List");
            //Console.WriteLine(textStr);
            textStr.Append(" - Updated");
            Console.WriteLine(textStr);


            //Q4.Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            textStr.Replace("Book List", "Library");
            Console.WriteLine(textStr);







        }
    }
}
