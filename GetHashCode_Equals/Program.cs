using GetHashCode_Equals.Entities;
using System.ComponentModel.DataAnnotations;

namespace GetHashCode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/Equals

            string a = "Maria";
            string b = "Maria";
            Console.WriteLine(a.Equals(b));

            //GetHashCode

            string c = "Maria";
            string d = "Alex";
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            */

            Client a = new Client("Franchesco", "franchescodsa@gmail.com");
            Client b = new Client("Miguel", "Miguel@gmail.com");

            Console.WriteLine(a.Equals(b));


        }
    }
}
