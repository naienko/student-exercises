using System;
using System.Collections.Generic;

namespace StudentExercises
{
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
        }
    }
}