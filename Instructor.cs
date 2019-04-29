/*
You must define a type for representing an instructor in code.

First name
Last name
Slack handle
The instructor's cohort
A method to assign an exercise to a student
  */

using System;

namespace student_exercises
{
    class Instructor : Person
    {

        public void AssignExercise(Exercise exerciseToAssign, Student studentToAssign){
            studentToAssign.Exercises.Add(exerciseToAssign);

            Console.WriteLine($"{FirstName} just assigned {exerciseToAssign.Name} to {studentToAssign.FirstName}.");

        }
    }
}