using System;
using System.Collections;
using System.IO;

namespace RandomSponegbobQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = @"C:\Users\Lenovo\Desktop\Programming Projects\Visual Studio Projects\C# Projects\Console Projects\RandomSponegbobQuotes\RandomSponegbobQuotes\spongebob.txt";

            ArrayList quotes = new ArrayList();

            foreach (string line in File.ReadAllLines(location))
            {
                quotes.Add(line);
            }

            Random rand = new Random();

            while (true)
            {
                Console.WriteLine(quotes[rand.Next(quotes.Count)]);
                Console.WriteLine("Enter y if you want to see another random quote: ");

                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
