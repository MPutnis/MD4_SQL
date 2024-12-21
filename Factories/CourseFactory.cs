using Bogus;
using MD4_SQL.Data;

namespace MD4_SQL.Factories
{
    public static class CourseFactory
    {
        private static int _idCounter = 1;
        public static Course Create(int teacherId)
        {
            var faker = new Faker<Course>()
                .RuleFor(c => c.Id, _ => _idCounter++)
                .RuleFor(c => c.Name, f => f.Lorem.Word())
                .RuleFor(c => c.TeacherId, _ => teacherId);

            return faker.Generate();
        }

        public static List<Course> CreateMany(int count, List<int> teacherIds)
        {
            var courses = new List<Course>();
            for (int i = 0; i < count; i++)
            {
                // Get the teacher id from the list of teacher ids in a round-robin fashion
                var teacherId = teacherIds[i % teacherIds.Count];
                courses.Add(Create(teacherId));
            }

            return courses;
        }
    }
}
