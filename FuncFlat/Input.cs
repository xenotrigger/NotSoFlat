using static System.Console;
using System.Threading;
using PrintText;
using Logical;

namespace TakeText
{
    public static class Take
    {
        public static string? Response1;
        public static string? Response2;
        public static string Answer1()
        {
            Response1 = ReadLine();

            return Response1 ??"";
        }

        public static string Answer2()
        {
            Response2 = ReadLine();

            return Response2 ??"";
        }
    }
}