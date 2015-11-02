using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaToCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Menu menu = new Menu("duom.txt", "results.txt");
            menu.showMenu();
        }
    }
}
