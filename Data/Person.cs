using Humanizer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MD4_SQL.Data
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [NotMapped]
        public string FullName => $"{Name} {Surname}".Titleize(); // Humanizer added by copilot

        // Constructor
        public Person(string name, string surname, Gender gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
        }
        // Empty constructor
        public Person() { }
    }
}
