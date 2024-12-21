using Bogus;
using MD4_SQL.Data;

namespace MD4_SQL.Factories
{
    public static class AssignmentFactory
    {
        private static int _idCounter = 1;
        public static Assignment Create(int courseId)
        {
            var faker = new Faker<Assignment>()
                .RuleFor(a => a.Id, _ => _idCounter++)
                .RuleFor(a => a.Description, f => f.Lorem.Word())
                .RuleFor(a => a.CourseId, _ => courseId)
                .RuleFor(a => a.Deadline, f => f.Date.Future(1));
            return faker.Generate();
        }
        public static List<Assignment> CreateMany(int count, List<int> courseIds)
        {
            var assignments = new List<Assignment>();
            for (int i = 0; i < count; i++)
            {
                var courseId = courseIds[i % courseIds.Count];
                assignments.Add(Create(courseId));
            }
            return assignments;
        }
    }
}
