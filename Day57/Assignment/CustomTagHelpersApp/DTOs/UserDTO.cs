using System.ComponentModel.DataAnnotations;

namespace CustomTagHelpersApp.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
       
    }
}
