using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = (Console.ReadLine());
            if (Text == "s3cr3t!P@ssw0rd")
              {
                Console.WriteLine("Welcome");
              }
            else
              {
                Console.WriteLine("Wrong password!");
              }
        }
    }
}
