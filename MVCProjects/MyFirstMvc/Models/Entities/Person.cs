using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstMvc.Models.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "FirstName must be 20 characters or less"), MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "LastName must be 50 characters or less"), MinLength(2)]
        public string LastName { get; set; }

        [MaxLength(50, ErrorMessage = "Address must be 50 characters or less"), MinLength(2)]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Email must be 50 characters or less"), MinLength(9)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
    }
}
