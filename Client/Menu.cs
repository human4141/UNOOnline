﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public class Menu
    {
        public void DisplayMainMenu()
        {
            string[] menuItems = {"Join Game", "Create Game", "Help", "Exit"};

            int menuPosition = DisplayMenu(menuItems);

            switch (menuPosition)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        public int DisplayMenu(string[] menuItems)
        {
            int cursorPosition = 0;

            while (true)
            {
                DisplayGameHeader();

                Console.WriteLine();

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == cursorPosition)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine(menuItems[i]);
                }

                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (cursorPosition + 1 == menuItems.Length)
                    {
                        cursorPosition = 0;
                    }
                    else
                    {
                        cursorPosition++;
                    }
                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (cursorPosition - 1 < 0)
                    {
                        cursorPosition = menuItems.Length - 1;
                    }
                    else
                    {
                        cursorPosition--;
                    }
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    break;
                }

                Console.Clear();
            }

            return cursorPosition;
        }

        public void DisplayGameHeader()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("  _    _                ____        _ _            ");
            Console.WriteLine(" | |  | |              / __ \\      | (_)           ");
            Console.WriteLine(" | |  | |_ __   ___   | |  | |_ __ | |_ _ __   ___ ");
            Console.WriteLine(" | |  | | '_ \\ / _ \\  | |  | | '_ \\| | | '_ \\ / _ \\");
            Console.WriteLine(" | |__| | | | | (_) | | |__| | | | | | | | | |  __/");
            Console.WriteLine("  \\____/|_| |_|\\___/   \\____/|_| |_|_|_|_| |_|\\___|");

            Console.ResetColor();
        }
    }
}