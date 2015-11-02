using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    public class Menu
    {
        private ReadWrite readWrite;
        bool a = true;

        public Menu(string txtFile1, string txtFile2)
        {
            readWrite = new ReadWrite(txtFile1, txtFile2);
        }

        public void showMenu()
        {

        }

    }
}
