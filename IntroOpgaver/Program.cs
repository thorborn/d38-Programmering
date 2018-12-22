using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            //opg 1
            Console.ForegroundColor = ConsoleColor.Red; //tekst farve
            Console.WriteLine("Jeg glæder mig til C#"); //console tekst
            //Console.ReadKey(); //udskriver til konsol
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            //opg 2
            Console.ForegroundColor = ConsoleColor.Blue; //tekst farve
            Console.BackgroundColor = ConsoleColor.Yellow; //tekst farve
            Console.WriteLine("Jeg glæder mig meget til C#"); //console tekst
            //Console.ReadKey(); //udskriver til konsol
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            //opg 3
            Console.ForegroundColor = ConsoleColor.Blue; //tekst farve
            Console.BackgroundColor = ConsoleColor.Yellow; //tekst farve
            Console.WriteLine("Jeg glæder mig super meget til C#"); //console tekst
            //Console.ReadKey(); //udskriver til konsol
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            //opg 4
            Console.SetCursorPosition(30, 4);
            Console.ForegroundColor = ConsoleColor.Green; //tekst farve
            Console.BackgroundColor = ConsoleColor.Gray; //tekst farve
            Console.WriteLine("Jeg glæder mig super meget til C#"); //console tekst
            //Console.ReadKey(); //udskriver til konsol
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            //opg 5
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = ConsoleColor.Green; //tekst farve
            Console.WriteLine("Grøn"); //console tekst
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Yellow; //tekst farve
            Console.WriteLine("Gul"); //console tekst
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = ConsoleColor.Blue; //tekst farve
            Console.WriteLine("Blå"); //console tekst
            Console.SetCursorPosition(5, 12);
            Console.ForegroundColor = ConsoleColor.Red; //tekst farve
            Console.WriteLine("Rød"); //console tekst
            Console.CursorVisible = false;
            //Console.ReadKey(); //udskriver til konsol
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            //opg 6
            Console.SetCursorPosition(9, 5);
            Console.ForegroundColor = ConsoleColor.Green; //tekst farve
            Console.BackgroundColor = ConsoleColor.Yellow; //tekst farve
            Console.WriteLine("Johnny Johnson"); //console tekst
            Console.SetCursorPosition(9, 6);
            Console.ForegroundColor = ConsoleColor.Yellow; //tekst farve
            Console.BackgroundColor = ConsoleColor.Green; //tekst farve
            Console.WriteLine("69th John Street"); //console tekst
            Console.SetCursorPosition(9, 7);
            Console.ForegroundColor = ConsoleColor.Blue; //tekst farve
            Console.BackgroundColor = ConsoleColor.Red; //tekst farve
            Console.WriteLine("420 Johnnytown"); //console tekst
            Console.SetCursorPosition(9, 8);
            Console.ForegroundColor = ConsoleColor.Red; //tekst farve
            Console.BackgroundColor = ConsoleColor.Blue; //tekst farve
            Console.WriteLine("+911 420 6969"); //console tekst
            Console.CursorVisible = false;
            Console.ReadKey(); //udskriver til konsol 
            Console.ResetColor();
            Console.Clear();
        }
    }
}
