/*Cohort
You must define a type for representing a cohort in code.

The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
The collection of students in the cohort.
The collection of instructors in the cohort.
*/

using System;
using System.Collections.Generic;

namespace student_exercises{

    class Cohort{

        public int id {get; set;}
        public string name {get; set;}

        // List of students in this cohort
        public List<Student> StudentList {get; set;} = new List<Student>();

        // List of Instructors for this cohort
        public List<Instructor> InstructorList {get; set;} = new List<Instructor>();



    }

}