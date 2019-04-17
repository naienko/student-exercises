using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises {
	public class NSSPerson {
		public string _firstname { get; set; }
		public string _lastname { get; set; }
		public string _handle { get; set; }
		public Cohort _cohort;

		public void AssignCohort (Cohort cohort) {
			_cohort = cohort;
		}
	}
}