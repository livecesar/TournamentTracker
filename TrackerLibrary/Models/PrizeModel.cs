using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Place identifier: 1st 2d 3d...
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Place identifier name
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Amount destinated for this place in particular
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Percentage of the total prize
        /// </summary>
        public double PizePercentage { get; set; }
    }
}
