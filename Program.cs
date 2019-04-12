using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    public class StudentsInCohort {
        public Cohort cohortName { get; set; }
        public int cohortCount { get; set; }
    }
    class Program
    {
        static void Main()
        {
            /* Create 4, or more, exercises.
Create 3, or more, cohorts.
Create 4, or more, students and assign them to one of the cohorts.
Create 3, or more, instructors and assign them to one of the cohorts.
Have each instructor assign 2 exercises to each of the students. */

            Exercise Journal = new Exercise ("Student Journal", "Javascript");
            Exercise KandyKorner = new Exercise ("Kandy Korner", "React") {};
            Exercise CarLot = new Exercise ("Car Lot", "C#");
            Exercise Personal = new Exercise ("Personal Website", "HTML");

            Cohort thirty = new Cohort ("Cohort 30");
            Cohort twentynine = new Cohort ("Cohort 29");
            Cohort eveningeight = new Cohort ("Evening 8");

            Student pEris = new Student ("Panya Gwynn-Eris", "naienko");
            Student sRainault = new Student ("Summer Rainault", "firechild");
            Student bAllen = new Student ("Bartholomew Allen", "theflash");
            Student kDubhglas = new Student ("Kieran Dubhglas", "eolascraicte");

            Instructor sBrownlee = new Instructor ("Steve Brownlee", "chortlehoort");
            Instructor sStCyr = new Instructor ("Sebastien StCyr", "elementalist");
            Instructor eThawne = new Instructor ("Eobard Thawne", "reverseflash");

            thirty.AddStudents(new List<Student> {sRainault, bAllen}, thirty);
            thirty.AddInstructors(eThawne, thirty);

            eveningeight.AddStudents(kDubhglas, eveningeight);
            eveningeight.AddInstructors(sBrownlee, eveningeight);

            twentynine.AddStudents(pEris, twentynine);
            twentynine.AddInstructors(sStCyr, twentynine);

            sBrownlee.AssignExercise(Personal, kDubhglas);
            sStCyr.AssignExercise(Journal, pEris);
            eThawne.AssignExercise(KandyKorner, new List<Student> {sRainault, bAllen});

            eThawne.AssignExercise(CarLot, sRainault);
            eThawne.AssignExercise(Journal, bAllen);

            sStCyr.AssignExercise(Personal, pEris);

            sBrownlee.AssignExercise(Journal, kDubhglas);

            Console.WriteLine(thirty);
            Console.WriteLine(twentynine);
            Console.WriteLine(eveningeight);

            List<Student> students = new List<Student>() {
                pEris, bAllen, sRainault, kDubhglas
            };
            List<Exercise> exercises = new List<Exercise>() {
                Journal, CarLot, KandyKorner, Personal
            };
            List<Instructor> instructors = new List<Instructor>() {
                sBrownlee, eThawne, sStCyr
            };
            List<Cohort> cohorts = new List<Cohort>() {
                eveningeight, twentynine, thirty
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.
            var javascriptExercises = exercises.Where(e => e.Language == "Javascript");
            Console.WriteLine("Exercises in Javascript");
            foreach (var item in javascriptExercises) {
                Console.WriteLine(item);
            }

Console.WriteLine(" ");
            //List students in a particular cohort by using the Where() LINQ method.
            var cohortThirtyStudents = students.Where(s => s._cohort == thirty);
            Console.WriteLine("Cohort Thirty students");
            foreach (var item in cohortThirtyStudents) {
                Console.WriteLine(item);
            }

Console.WriteLine(" ");
            //List instructors in a particular cohort by using the Where() LINQ method.
            var cohortTwentynineInstructors = instructors.Where(i => i._cohort == twentynine);
            Console.WriteLine("Cohort Twenty Nine Instructors");
            foreach (var item in cohortTwentynineInstructors) {
                Console.WriteLine(item);
            }

Console.WriteLine(" ");
            //Sort the students by their last name.
            IEnumerable<Student> byLastName = from student in students
                orderby student._lastname ascending
                select student;
            Console.WriteLine("Sort by last name");
            foreach (var item in byLastName) {
                Console.WriteLine(item);
            }   

Console.WriteLine(" ");
            //Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Student tMaclyr = new Student ("Teleri MacLyr", "selkiegirl");
            students.Add(tMaclyr);
            IEnumerable<Student> boredStudent = from student in students
                where student.Exercises.Count == 0
                select student;
            Console.WriteLine("Students who have no exercises");
            foreach (var item in boredStudent) {
                Console.WriteLine(item);
            }

Console.WriteLine(" ");
            //Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            eThawne.AssignExercise(Personal, sRainault);
            IEnumerable<Student> starStudents = from student in students 
                orderby student.Exercises.Count descending
                select student;
            Console.WriteLine("The student who has the most exercises");
            Console.WriteLine(starStudents.First());

Console.WriteLine(" ");
            //How many students in each cohort?
            List<StudentsInCohort> studentsPerCohort = (
                from student in students
                group student by student._cohort into cohortGroup
                select new StudentsInCohort {
                    cohortName = cohortGroup.Key,
                    cohortCount = cohortGroup.Count()
                }
            ).ToList();
            foreach (StudentsInCohort entry in studentsPerCohort)
            {
                try{
                Console.WriteLine($"{entry.cohortName.Name} has {entry.cohortCount} students in it.");
                }
                catch (NullReferenceException) {
                    Console.WriteLine($"There are unassigned students!");
                }
            }
        }
    }
}