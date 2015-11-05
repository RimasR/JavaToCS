using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    class Match
    {
        private bool isLive;
        private bool matchEnded;
        private string homeTeam;
        private string visitorTeam;
        private int firstTeamScore;
        private int secondTeamScore;
        private string stadiumName;

        public Match()
        {
            this.homeTeam = null;
            this.visitorTeam = null;
            this.firstTeamScore = 0;
            this.secondTeamScore = 0;
        }
    }
}
