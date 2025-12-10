using static System.Console;
using System.Threading;
using TakeText;
using Logical;

namespace PrintText
{
    public class Print
    {
    

        //Typewriter effect
        public static void Effect(string text, int speed = 10)
        {
            foreach (char c in text)
            {
                Write(c);
                Thread.Sleep(speed);
            }
        }

        public static void EffectFast(string text, int speed = 1)
        {
            foreach (char c in text)
            {
                Write(c);
                Thread.Sleep(speed);
            }
        }

        public static void Bruh()
        {
            Effect("Bruh, you gotta pick either Round or Flat!", 20);
            WriteLine();
            Effect("Your not a Square Earther are you?! >.> ", 20);
        }
    
        public static void Q1Think()
        {
            WriteLine();
            WriteLine();
            Effect("Do you think the Earth is Round or Flat? ");
            WriteLine();
            Effect("A. Round, duh!");
            WriteLine();
            Effect("B. Flat, no brainer!");
            WriteLine();
        }

        public static void Q2Think()
        {
            WriteLine();
            Effect("Ummmmm...");
            Thread.Sleep(1000);
            WriteLine();
            Effect("Ohh, Okaaaaay ....");
            Thread.Sleep(2000);
            WriteLine();
            Effect($"So you sure you believe that the {Logic.Shape}? ... ");
            Thread.Sleep(2000);
            WriteLine();
            Effect("That's a little weird bruh ... ");
            Thread.Sleep(1000);
            WriteLine();
            WriteLine();
            Effect("I tell ya what...");
            Effect("I'll give you an opportunity to convince me.");
            Thread.Sleep(1000);
            WriteLine();
            Effect("Give me a short and simple statement ");
            Thread.Sleep(1000);
            WriteLine();
            Effect($"as to why you believe the {Logic.Shape}.");
            WriteLine();
            
        }

        public static void Conclusion()
        {
            Effect("Okay, lets see here ... ");
            Thread.Sleep(1000);
            WriteLine();
            Effect(". ");
            Thread.Sleep(1000);
            WriteLine();
            Effect(".. ");
            Thread.Sleep(1000);
            WriteLine();
            Effect("... ");
            Thread.Sleep(1000);
            WriteLine();
            Effect("yaaaa... ");
            Thread.Sleep(1000);
            WriteLine();
            Effect("riiiight ... ");
            Thread.Sleep(1000);
            WriteLine();
            Effect($"So, you think because {Take.Response2} that the {Logic.Shape}, huh?");
            Thread.Sleep(3000);
            WriteLine();
            Effect($"Ya, no, I believe that the {Logic.Disagree}, sorry");
            Thread.Sleep(1000);
            WriteLine();
            Effect("Not Sorry!");
            WriteLine();
        }

        public static void Q1A()
        {
            Effect($"Wait, you think that the {Logic.Shape}!");
        }

        public static void Q1B()
        {
            Effect($"Wait, you think that the {Logic.Shape}!");
        }
        
        public static void Exit()
        {
            WriteLine();
            Effect("Press any key to exit.");
            ReadKey(true);
        }
    }

    public class Ascii
    {
        public static void Title()
        {
            Print.EffectFast(@"

             _   _       _     _____        ______ _       _   
            | \ | |     | |   /  ___|       |  ___| |     | |  
            |  \| | ___ | |_  \ `--.  ___   | |_  | | __ _| |_ 
            | . ` |/ _ \| __|  `--. \/ _ \  |  _| | |/ _` | __|
            | |\  | (_) | |_  /\__/ / (_) | | |   | | (_| | |_ 
            \_| \_/\___/ \__| \____/ \___/  \_|   |_|\__,_|\__|
                                     Divergent Interactive 2025
            ", 1);
         

        }
    }
   
}
