using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    class Student
    {
    	private string _firstname;
		private string _lastname;
		private string _handle;

		public Cohort _cohort;

		public List<Exercise> Exercises { get; private set; } = new List<Exercise>();

		public Student (string fullname, string slackHandle) {
			string [] names = fullname.Split(" ");
			_firstname = names[0];
			_lastname = names[1];
			_handle = slackHandle;
		}

	   	public Student AssignCohort (Cohort cohort) {
		   _cohort = cohort;
		   return this;
	   	}

		public override string ToString() {
			StringBuilder output = new StringBuilder($@"{_firstname} {_lastname}, slack handle: {_handle}
	Working on: 
");
			Exercises.ForEach(e => output.Append($"{e}\n"));
			return output.ToString();
		}
    }
}