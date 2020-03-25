using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
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
