using System.ComponentModel.DataAnnotations;

/*
 * Rohith Pulyala
 * CIS 174
 * 
 * 1/27/2026
*/
namespace ContactManager.Models
{
    public class Contact
    {
        //Getters and Setters

        [Key]
        public int Id { get; set; } // Primary Key

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required] 
        public string Address { get; set; }

        public string Note { get; set; }
    }
}
