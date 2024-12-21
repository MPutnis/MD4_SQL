using Bogus;
using MD4_SQL.Data;

namespace MD4_SQL.Factories
{
    public static class TeacherFactory
    {
        private static int _idCounter = 1;
        public static Teacher Create()
        {
            var faker = new Faker<Teacher>()
                .RuleFor(t => t.Id, _ => _idCounter++)
                .RuleFor(t => t.Name, f => f.Name.FirstName())
                .RuleFor(t => t.Surname, f => f.Name.LastName())
                .RuleFor(t => t.Gender, f => f.PickRandom<Gender>())
                .RuleFor(t => t.ContractDate, f => f.Date.Past(15));

            return faker.Generate();
        }

        public static List<Teacher> CreateMany(int count)
        {
            var teachers = new List<Teacher>();
            for (int i = 0; i < count; i++)
            {
                teachers.Add(Create());
            }

            return teachers;
        }
    }
}
