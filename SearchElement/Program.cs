using SearchElement.Classes;
using SearchElement.Classes.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Context c = new Context();
            Menu.StartMenu(c);
        }
    }
}
