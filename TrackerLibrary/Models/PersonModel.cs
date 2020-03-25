using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Unique identifier for person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name(s)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Lasts names
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Primary email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Primary cellphone number
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        { get { return $"{ FirstName } { LastName }"; } }
    }
}
