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
        Input input = new Input();
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
            bool valid = false;
            try
            {
                
            } catch (Exception e)
            {

            }

            while (!valid)
            {
                Team team1 = new Team(input.GetText("Choose first team name: "));
                x = 1;
                while(x == 1)
                {
                    Player player = new Player();
                    player.SetName(input.GetText("Enter players full name: "));
                    player.SetPosition(input.GetText("Enter players position: "));
                    player.SetPlayerNumber(input.GetNumber("Enter players number: ", 0, 99));
                    team1Players.Add(player);
                    x = input.GetNumber("Would you like to add new player? 0 - no, 1 - yes", 0, 1); 
                }

                Console.WriteLine("First team created.");

                Team team2 = new Team(input.GetText("Choose first team name: "));
                x = 1;
                while (x == 1)
                {
                    Player player = new Player();
                    player.SetName(input.GetText("Enter players full name: "));
                    player.SetPosition(input.GetText("Enter players position: "));
                    player.SetPlayerNumber(input.GetNumber("Enter players number: ", 0, 99));
                    team2Players.Add(player);
                    x = input.GetNumber("Would you like to add new player? 0 - no, 1 - yes", 0, 1);
                }
            }
        }

    }
}
