```c#
   List<Student> StudentList = new List<Student>(){
                Sable,
                Matt,
                David,
                Bobby
            };

            List<Exercise> ExerciseList = new List<Exercise>(){
                ChickenMoneky,
                Kennel,
                BoyBands,
                ContactList,
                StudentExercises,
                KillNickleback
            };

            List<Cohort> CohortList = new List<Cohort>(){
                One,
                Two,
                Three
            };

            List<Instructor> InstructorList = new List<Instructor>(){
                Jordan,
                Kim,
                Josh
            };

            foreach (Exercise exercise in ExerciseList)
            {
                List<Student> CurrentStudents = new List<Student>();
                foreach (Student student in StudentList)
                {
                    foreach (Exercise studentExercise in student.Exercises)
                    {
                        if (studentExercise == exercise)
                        {
                            CurrentStudents.Add(student);
                        }
                    }
                }

                Console.WriteLine($"Here are the students working on {exercise.Name}:");
                foreach (Student currentStudent in CurrentStudents)
                {
                    Console.WriteLine(currentStudent.FirstName);
                }
            }
```

```c#
One.Students.Add(Sable);
One.Students.Add(Matt);
List<int> studentIds = new List<int>(){0, 1, 4, 11};

foreach(int id in studentIds){
    try{
        Student foundStudent = One.getStudentById(id);
        Console.WriteLine($"We found the following student: {foundStudent.FirstName}");
    }
    catch(System.ArgumentOutOfRangeException){
        Console.WriteLine($"Couldn't find the student with an id of {id}");
    }

}
```
