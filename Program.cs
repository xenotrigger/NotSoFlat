using static System.Console;
using PrintText;
using TakeText;
using Logical;


namespace Flat
{
    class ProgramFlat
    {
        static void Main(string[] args)
        {
            Ascii.Title();

            Print.Q1Think();

            Take.Answer1();

            Logic.Info1();

            Print.Q2Think();

            Take.Answer2();

            int ResultAdd1 = SomeMethod();
            WriteLine($"Your favorite number plus 1 is {ResultAdd1}");

            Print.Conclusion();

            Print.Exit();
        }

        static int SomeMethod()
        {   
            WriteLine("What is your favorite number?  Lets add 1 to it");

            string? input = ReadLine();
            int SomeParameter = int.Parse(input!);

            int result = SomeParameter + 1 ;
            

            return result;
        }
    }
}