using System.ComponentModel.DataAnnotations;

namespace MD4_SQL.Data
{
    public class Teacher : Person
    {
        [Required]
        public DateTime ContractDate { get; set; }

        // Constructors
        public Teacher() { }
        public Teacher(string name, string surname, Gender gender, DateTime contractDate) : 
            base(name, surname, gender)
        {
            ContractDate = contractDate;
        }

    }
}
