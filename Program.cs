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

            Print.Conclusion();

            Print.Exit();
        }
    }
}