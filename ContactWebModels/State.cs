using System.ComponentModel.DataAnnotations;

namespace ContactWebModels
{
    public class State
    {
        // Indicates the the Id will be the primary key
        [Key]
        public int Id { get; set; }

        // Will map this to a UI field called State
        [Display(Name = "State")]
        // Ensures that name is required and provides and error message
        [Required(ErrorMessage = "Name of State is required")]
        // Without setting string length, it will be the max VARCHAR length of 4000 characters
        [StringLength(ContactManagerConstants.MAX_STATE_NAME_LENGTH)] 
        public string Name { get; set; }

        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(ContactManagerConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
