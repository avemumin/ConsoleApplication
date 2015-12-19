using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Menu
{
    class MenuController
    {
        List<MenuEntry> lista;
        public string Text { get; set; }
        public MenuController(string text)
        {
            Text = text;
            lista = new List<MenuEntry>();
        }
        public void PrintMenu()
        {
            int position = 1;
            Console.WriteLine("---- {0} ----", Text);

            foreach (MenuEntry item in lista)
            {
                Console.WriteLine(" {0}) {1} ", position++, item.TextOnTitle);
            }
        }

        public void StartProgram()
        {
            ConsoleKeyInfo someKey;
            do
            {
                Console.Clear();
                PrintMenu();
                someKey = Console.ReadKey();
                ExecuteEntry(someKey);
            } while (true);
        }

        public void ExecuteEntry(ConsoleKeyInfo key)
        {
            if (!char.IsDigit(key.KeyChar))
                return;
            int position = 1;
            int num = key.KeyChar - '0';
            foreach (MenuEntry item in lista)
            {
                if (position++ == num)
                {
                    item.execute();
                    return;
                }
            }
        }

    }
}
