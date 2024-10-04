using eTicketMvcApp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicketMvcApp.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int  ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "ProfilePicture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
