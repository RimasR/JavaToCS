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

        public void startMenu()
        {
            if (!readWrite.ReadFiles())
            {
                Console.WriteLine("Unable to read files \n Terminating program.");
                Environment.Exit(0);
            }
            showMenu();
        }

        public void showMenu()
        {
            List<Player> team1Players = new List<Player>();
            List<Player> team2Players = new List<Player>();
            int x;
            try
            {
                
            } catch (Exception e)
            {

            }
        }

    }
}
