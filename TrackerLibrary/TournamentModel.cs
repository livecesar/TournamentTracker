using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Representation of a tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Particular tournament name
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Participation entry fee 
        /// (how much does it cost to enter the tournament)
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Participant teams
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Actual list of prizes (for the 1st, 2d, 3d ... place)
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the matches played in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
