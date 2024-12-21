using Bogus;
using MD4_SQL.Data;

namespace MD4_SQL.Factories
{
    public static class StudentFactory
    {
        // Asked Copilot how to generate fake data
        // count instances of created objects
        private static int _idCounter = 1;
        public static Student Create()
        {
            var faker = new Faker<Student>()
                .RuleFor(s => s.Id, _ => _idCounter++)
                .RuleFor(s => s.Name, f => f.Person.FirstName)
                .RuleFor(s => s.Surname, f => f.Person.LastName)
                .RuleFor(s => s.Gender, f => f.PickRandom<Gender>())
                .RuleFor(s => s.StudentIdNumber, f => f.Random.Replace("SN#####"));

            return faker.Generate();
        }

        public static List<Student> CreateMany(int count)
        {
            var students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                students.Add(Create());
            }

            return students;
        }
    }
}
