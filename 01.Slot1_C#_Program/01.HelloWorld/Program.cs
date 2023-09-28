// See https://aka.ms/new-console-template for more information

namespace first_trial
{
    public class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.ReadLine();
        }



    }
}


