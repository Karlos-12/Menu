using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int hg = 0;
            Menu(hg);
            do
            {
                
                if (Console.ReadKey(true).Key != ConsoleKey.UpArrow)
                {
                    hg = hg + 1;
                    if (hg > 4)
                    {
                        hg = 0;
                    }
                    if (hg < 0)
                    {
                        hg = 4;
                    }
                    Console.Clear();
                    Menu(hg);
                    
                }
                if (Console.ReadKey(true).Key != ConsoleKey.DownArrow)
                {
                    hg = hg - 1;
                    if (hg > 4)
                    {
                        hg = 0;
                    }
                    if (hg < 0)
                    {
                        hg = 4;
                    }
                    Console.Clear();
                    Menu(hg);
                    
                }                
            }
            while (true);
            }
        static void Menu(int hig)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("=================");
            Console.WriteLine("‖ Chose a color ‖");
            Console.WriteLine("=================");

            if (hig == 0)
            { Console.BackgroundColor = ConsoleColor.Green; }
            Console.WriteLine("‖     Green     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (hig == 1)
            { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.WriteLine("‖      Blue     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (hig == 2)
            { Console.BackgroundColor = ConsoleColor.Red; }
            Console.WriteLine("‖     Red       ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (hig == 3)
            { Console.BackgroundColor = ConsoleColor.White; }
            Console.WriteLine("‖     White     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (hig == 4)
            { Console.BackgroundColor = ConsoleColor.Yellow; }
            Console.WriteLine("‖    Yellow     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("=================");
           
        }

    }
}
