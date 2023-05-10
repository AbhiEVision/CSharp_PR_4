namespace CSharp_PR_4
{
	public class Student
	{
		public string name;
		public decimal[] marks = new decimal[5];

		public static decimal avgMarks;

		// Calculating Avg Marks of student
		public decimal CalculateAverageMarks()
		{
			return ((decimal)marks.Sum()) / 5;
		}

		// returning the grade of user 
		public string CalculateGrade(decimal marks)
		{
			switch (marks)
			{
				case > 90:
					return "A";
				case > 80:
					return "B";
				case > 70:
					return "C";
				default:
					return "D";
			}
		}

		// student initialization function
		public void InitializeStudent()
		{
			// initializing the name
			Console.Write("Please Enter your Name : ");
			name = Console.ReadLine();

			// initializing the marks
			for (int i = 0; i < 5; i++)
			{
				marks[i] = Program.TakeDecimalFromUser(i + 1);
			}

		}

		// Aggregate function
		public void AggrigateFunc()
		{
			Console.WriteLine($"\nName : {name}");
			Console.WriteLine($"Average Marks : {CalculateAverageMarks()}");
		}

		// min mark function
		public void MinMarkFunc()
		{
			Console.WriteLine($"\nminimum marks from all subject : {marks.Min()}");
		}

		// max mark function
		public void MaxMarkFunc()
		{
			Console.WriteLine($"\nminimum marks from all subject : {marks.Max()}");
		}

		// Grade printing function
		public void PrintGradeFunc()
		{
			Console.WriteLine($"\nyour grade is : {CalculateGrade(CalculateAverageMarks())}");
		}
	}
}
