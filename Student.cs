using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    public class Student
    {
    	public string _firstname { get; }
		public string _lastname { get; }
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
			StringBuilder output = new StringBuilder($@"{_firstname} {_lastname}");
			//output.Append($", slack handle: {_handle}");
			//Exercises.ForEach(e => output.Append($"{e}\n"));
			return output.ToString();
		}
    }
}