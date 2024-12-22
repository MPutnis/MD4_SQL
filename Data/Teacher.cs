using System.ComponentModel.DataAnnotations;

namespace MD4_SQL.Data
{
    public class Teacher : Person
    {
        [Required]
        // Make it so only the date is shown, Copilot showed how
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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
