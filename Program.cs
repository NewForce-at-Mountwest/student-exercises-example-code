using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Objective
  The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

  Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

  Create 4, or more, exercises.
  Create 3, or more, cohorts.
  Create 4, or more, students and assign them to one of the cohorts.
  Create 3, or more, instructors and assign them to one of the cohorts.
  Have each instructor assign 2 exercises to each of the students.

   */

            Exercise kennel = new Exercise()
            {
                Name = "Kennel",
                Language = "JavaScript"
            };

            Exercise nutshell = new Exercise()
            {
                Name = "Nutshell",
                Language = "JavaScript"
            };

            Exercise boogers = new Exercise()
            {
                Name = "boogers",
                Language = "JavaScript"
            };

            Exercise chickenMonkey = new Exercise()
            {
                Name = "Chicken Monkey",
                Language = "JavaScript"
            };

            Exercise familyDictionary = new Exercise()
            {
                Name = "Family Dictionary",
                Language = "C#"
            };


            Cohort cohortOne = new Cohort()
            {
                name = "Cohort One"
            };

            Student russ = new Student()
            {
                FirstName = "Russ",
                LastName = "Miller",
                SlackHandle = "@Russ",
                CurrentCohort = cohortOne
            };

            Student bobby = new Student()
            {
                FirstName = "Bobby",
                LastName = "Fitzpatrick",
                SlackHandle = "@Bobby",
                CurrentCohort = cohortOne
            };

            Student sydney = new Student()
            {
                FirstName = "Sydney",
                LastName = "Wait",
                SlackHandle = "@Sydney",
                CurrentCohort = cohortOne
            };

            Student david = new Student()
            {
                FirstName = "David",
                LastName = "Bird",
                SlackHandle = "@David",
                CurrentCohort = cohortOne
            };

            Instructor Jordan = new Instructor()
            {
                FirstName = "Jordan",
                LastName = "Castelloe",
                SlackHandle = "@Jordan",
                CurrentCohort = cohortOne
            };


            Instructor Josh = new Instructor()
            {
                FirstName = "Josh",
                LastName = "Joseph",
                SlackHandle = "@Josh",
                CurrentCohort = cohortOne
            };

            Instructor Kim = new Instructor()
            {
                FirstName = "Kim",
                LastName = "Preece",
                SlackHandle = "@Kim",
                CurrentCohort = cohortOne
            };


            Kim.AssignExercise(kennel, russ);
            Josh.AssignExercise(boogers, bobby);
            Jordan.AssignExercise(chickenMonkey, sydney);
            Jordan.AssignExercise(chickenMonkey, russ);
            Jordan.AssignExercise(chickenMonkey, bobby);


            /*
           Challenge
           Create a list of students. Add all of the student instances to it.
           List<Student> students = new List<Student>();
           Create a list of exercises. Add all of the exercise instances to it.
           List<Exercise> exercises = new List<Exercise>();
           Generate a report that displays which students are working on which exercises. */

            List<Student> StudentList = new List<Student>(){
                russ,
                bobby,
                sydney,
                david
            };

            List<Exercise> ExerciseList = new List<Exercise>(){
                kennel,
                boogers,
                chickenMonkey,
                familyDictionary
            };

            // Loop through all exercises
            foreach (Exercise currentExercise in ExerciseList)
            {

                // For each exercise, create an empty list to store students working on that exercise
                List<Student> assignedStudents = new List<Student>();

                // Loop through all of the students
                foreach (Student currentStudent in StudentList)
                {

                    // Loop through all the exercises each student is working on
                    foreach (Exercise assignedExercise in currentStudent.Exercises)
                    {

                        // If they're working on the current exercise that we're looping over, add the student to the assignedStudent list
                        if (assignedExercise.Name == currentExercise.Name)
                        {
                            assignedStudents.Add(currentStudent);
                        }
                    }

                }

                string studentNames = "";

                foreach (Student currentStudent in assignedStudents)
                {
                    studentNames += $"{currentStudent.FirstName}, ";
                }

                if (assignedStudents.Count > 0)
                {
                    Console.WriteLine($"{studentNames} are working on {currentExercise.Name}");
                }

            }

            try
            {
                Exercise exerciseDetails = russ.getExerciseById(100);
                Console.WriteLine(exerciseDetails.Name);

                

            } catch (System.ArgumentOutOfRangeException){
                Console.WriteLine($"The student is not working on the exercise with that id.");
            }


        }
    }
}
