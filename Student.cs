using System;

namespace StudentExercises
{
    class Student
    {
       private string _firstname;
	   private string _lastname;
	   private string _handle;

	   public Cohort cohort;

	   public List<Exercise> Exercises { get; private set; } = new List<Exercise>();

	   public Student (string fullname, string slackHandle) {
			string [] names = fullname.Split(" ");
			_firstname = names[0];
			_lastname = names[1];
			_handle = slackHandle;
	   }

	   public Student AssignCohort (Cohort cohort) {
		   cohort = cohort;
		   return this;
	   }
    }
}
