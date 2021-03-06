using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    public class Cohort
    {
		public string Name { get; set ; }

		public List<Student> Students { get; private set; } = new List<Student>();
		public List<Instructor> Instructors { get; private set; } = new List<Instructor>();

		public Cohort (string name) {
			Name = name;
		}

		// public void AddStudents (Student students) {
		// 	Students.Add(students);
		// 	students.AssignCohort(this);
		// }
		public void AddStudents (Student students, Cohort cohort) {
			Students.Add(students);
			students.AssignCohort(cohort);
		}
		public void AddStudents (List<Student> students, Cohort cohort) {
			Students.AddRange(students);
			foreach (Student element in students) {
				element.AssignCohort(cohort);
			}
		}

		public void AddInstructors (Instructor instructors, Cohort cohort) {
			Instructors.Add(instructors);
			instructors.AssignCohort(cohort);
		}
		public void AddInstructors (List<Instructor> instructors, Cohort cohort) {
			Instructors.AddRange(instructors);
			foreach (Instructor element in instructors) {
				element.AssignCohort(cohort);
			}
		}

		public override string ToString() {
			StringBuilder output = new StringBuilder($@"
{Name}
Instructor
");
			Instructors.ForEach(i => output.Append($"{i}\n"));
			output.Append($@"Students
");
			Students.ForEach(s => output.Append($"{s}\n"));
			return output.ToString();
		}
    }
}