using System.ComponentModel.DataAnnotations;

namespace MyFirstMvc.Models.Entities
{
    public class PersonDetails
    {
        [Key]
        public int DetailsID { get; set; }
        public Person Person { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? WorkPosition { get; set; }
        public string? PictureURL { get; set; }
        public string? Education { get; set; }
        public EducationLevel? EducationLevel { get; set; }
    }
    public enum EducationLevel
    {
        ElementarySchool,
        HighSchool,
        Undergrad,
        Graduated
    }
}
