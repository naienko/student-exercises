using System;

namespace StudentExercises
{
    class Instructor
    {
       private string _firstname;
	   private string _lastname;
	   private string _handle;

	   public Cohort cohort;

	   public Instructor (string fullname, string slackHandle) {
			string [] names = fullname.Split(" ");
			_firstname = names[0];
			_lastname = names[1];
			_handle = slackHandle;
	   }

	   public Instructor AssignCohort (Cohort cohort) {
		   cohort = cohort;
		   return this;
	   }

	   public void AssignExercise (Exercise exercise, Student student) {
		   student[Exercises].Add(exercise);
	   }
	   public void AssignExercise (Exercise exercise, List<Student> student) {
		   foreach (Student element in student) {
			   element[Exercises].Add(exercise);
		   }
	   }
    }
}
