using System;

namespace student_exercises
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public Cohort CurrentCohort { get; set; }
    }
}