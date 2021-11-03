using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor send = ConsoleColor.Green;

            ConsoleKeyInfo pres;
            int hg = 0;
            Menu(send, hg);
            do
            {
                pres = Console.ReadKey();
                if (pres.Key == ConsoleKey.DownArrow)
                {
                    hg = hg + 1;

                    Console.Clear();
                    Menu(send, hg);


                }
                if (pres.Key == ConsoleKey.UpArrow)
                {
                    hg = hg - 1;

                    Console.Clear();
                    Menu(send, hg);

                }

                if (pres.Key == ConsoleKey.Enter)
                {
                    if (hg == 0)
                    {
                        send = ConsoleColor.Green;
                    }
                    if (hg == 1)
                    {
                        send = ConsoleColor.Blue;
                    }
                    if (hg == 2)
                    {
                        send = ConsoleColor.Red;
                    }
                    if (hg == 3)
                    {
                        send = ConsoleColor.White;
                    }
                    if (hg == 4)
                    {
                        send = ConsoleColor.Yellow;
                    }
                    Console.Clear();
                    Menu(send, hg);
                }

                if (hg > 4)
                {
                    hg = 0;
                    Console.Clear();
                    Menu(send, hg);
                }
                if (hg < 0)
                {
                    hg = 4;
                    Console.Clear();
                    Menu(send, hg);
                }
            }
            while (true);
        }
        static void Menu(ConsoleColor hig, int pos)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("=================");
            Console.WriteLine("‖ Chose a color ‖");
            Console.WriteLine("=================");

            if (pos == 0)
            { Console.BackgroundColor = hig; }
            Console.WriteLine("‖     Green     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (pos == 1)
            { Console.BackgroundColor = hig; }
            Console.WriteLine("‖      Blue     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (pos == 2)
            { Console.BackgroundColor = hig; }
            Console.WriteLine("‖     Red       ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (pos == 3)
            { Console.BackgroundColor = hig; }
            Console.WriteLine("‖     White     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            if (pos == 4)
            { Console.BackgroundColor = hig; }
            Console.WriteLine("‖    Yellow     ‖");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("=================");

        }

    }
}
