/*
Exercise
You must define a type for representing an exercise in code. An exercise can be assigned to many students.

Name of exercise
Language of exercise (JavaScript, Python, CSharp, etc.) */

using System;

namespace student_exercises{
    class Exercise{
        public int id {get; set;}

        public string Name {get; set;}

        public string Language {get; set;}
    }
}