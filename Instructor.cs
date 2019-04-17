using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
	public class Instructor : NSSPerson
	{
		public Instructor(string fullname, string slackHandle)
		{
			string[] names = fullname.Split(" ");
			_firstname = names[0];
			_lastname = names[1];
			_handle = slackHandle;
		}
		public void AssignExercise(Exercise exercise, Student student)
		{
			student.Exercises.Add(exercise);
		}
		public void AssignExercise(Exercise exercise, List<Student> student)
		{
			foreach (Student element in student)
			{
				element.Exercises.Add(exercise);
			}
		}

		public override string ToString()
		{
			StringBuilder output = new StringBuilder($@"{_firstname} {_lastname}");
			//output.Append($", slack handle: {_handle}");
			return output.ToString();
		}
	}
}