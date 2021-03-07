using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Represents the matchup that the team won and entered in this matchup
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }     
    }
}
