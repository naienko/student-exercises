using System;

namespace StudentExercises
{
	public class Exercise
	{
		public string Name { get; set; }
		public string Language { get; set; }

		public Exercise(string name, string language)
		{
			Name = name;
			Language = language;
		}

		public override string ToString()
		{
			return $@"{Name}, {Language}";
		}
	}
}