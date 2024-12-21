using System.ComponentModel.DataAnnotations;

namespace MD4_SQL.Data
{
    public class Student : Person
    {
        [Required]
        public string? StudentIdNumber { get; set; }

        //constructors
        public Student() { }
        public Student(string name, string surname, Gender gender, string studentIdNumber) :
            base(name, surname, gender)
        {
            StudentIdNumber = studentIdNumber;
        }
    }
}
