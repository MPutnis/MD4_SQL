using Bogus;
using MD4_SQL.Data;

namespace MD4_SQL.Factories
{
    public static class SubmissionFactory
    {
        private static int _idCounter = 1;
        public static Submission Create(int studentId, int assignmentId)
        {
            var faker = new Faker<Submission>()
                .RuleFor(s => s.Id, _ => _idCounter++)
                .RuleFor(s => s.SubmissionTime, f => f.Date.Future(1))
                .RuleFor(s => s.Score, f => f.Random.Int(0, 100))                
                .RuleFor(s => s.StudentId, _ => studentId)                
                .RuleFor(s => s.AssignmentId, _ => assignmentId);

            return faker.Generate();
        }

        public static List<Submission> CreateMany(int count, List<int> studentIds, List<int> assignmentIds)
        {
            var submissions = new List<Submission>();

            for (int i = 0; i < count; i++)
            {
                var studentId = studentIds[i % studentIds.Count];
                var assignmentId = assignmentIds[i % assignmentIds.Count];
                submissions.Add(Create(studentId, assignmentId));
            }

            return submissions;
        }
    }
}
