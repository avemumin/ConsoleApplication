using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Menu;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController control = new MenuController("Menu Główne");
            control.StartProgram();
        }
    }
}
