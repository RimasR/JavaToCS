using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    struct Player
    {
        private string name { get; set; }
        private string position { get; set; }
        private int playerNumber { get; set; }

        public string toString()
        {
            return name + " " + playerNumber + " " + position;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetPlayerNumber(int playerNumber)
        {
            this.playerNumber = playerNumber;
        }
    }
}
