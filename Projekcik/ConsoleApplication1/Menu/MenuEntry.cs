using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Menu
{
    abstract class MenuEntry
    {
        public string TextOnTitle { get; set; }
        public MenuEntry(string titleText)
        {
            TextOnTitle = titleText;
        }
    }
}
