using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Team set
        /// </summary>
        public List<PersonModel> TeamMenbers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// Particular team name
        /// </summary>
        public string TeamName { get; set; }
    }
}
