using System.ComponentModel.DataAnnotations;

namespace eTicketMvcApp.Models
{
    public class Actor
    {
        [Key]
        public int  ActorId { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
