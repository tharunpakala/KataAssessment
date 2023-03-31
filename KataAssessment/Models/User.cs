using System.ComponentModel.DataAnnotations;

namespace KataAssessment.Models
{
    public class User
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        [Display(Name = "City Name")]
        public string? CityName { get; set; }

        /// <summary>
        /// Gets or sets the year of joining.
        /// </summary>
        [Display(Name = "Year Of Joining")]
        public int YearOfJoining { get; set; }
    }
}
