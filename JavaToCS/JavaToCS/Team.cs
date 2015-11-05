using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    class Team
    {
        List<Player> players = new List<Player>();
        private string sponsors;
        private string teamName;

        public Team()
        {
            this.teamName = null;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public int GetNumberOfPlayers()
        {
            return players.Count;
        }
    }
}
