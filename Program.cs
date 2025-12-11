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

            SomeMethod();

            Print.Conclusion();

            Print.Exit();
        }

        static void SomeMethod()
        {   
            WriteLine("What is your favorite number?  Lets add 1 to it");
            string? input = ReadLine();
            int SomeParameter = int.Parse(input!);
            int SomeParameterAnd1 = SomeParameter + 1 ;
            WriteLine($"Your favorite number is {SomeParameter} and plus 1 is {SomeParameterAnd1}");
        }
    }
}