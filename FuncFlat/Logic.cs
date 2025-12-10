using static System.Console;
using System.Threading;
using Flat;
using PrintText;
using TakeText;

namespace Logical
{
    public static class Logic
    {
        
        public static string Shape { get; private set;} = "";
        public static string Disagree { get; private set;} = "";
        public static void Info1()
        {
            while (true)
            {
        
                if( Take.Response1 == "a" || Take.Response1 == "A")
                {
                    Shape = ("Earth is Round");
                    Disagree = ("Earth is Flat");
                    Print.Q1A();
                    break;
                    
                }
                else if( Take.Response1 == "b" || Take.Response1 == "B")
                {
                    Shape = ("Earth is Flat");
                    Disagree = ("I think the Earth is Round");
                    Print.Q1B();
                    break;
                    
                }
                else
                {
                    Print.Bruh();  
                    Print.Q1Think();
                    Take.Answer1();
                }
            }
        }

       
    }
}