namespace CSharp_PR_4
{
	internal class Program
	{
		// program entry point
		static void Main(string[] args)
		{
			Student student = new();
			student.InitializeStudent();
			TakingInputFromUserForFurtherProcess(student);
		}

		// taking marks form user
		public static decimal TakeDecimalFromUser(int i)
		{
			decimal result;
			while (true)
			{
				Console.Write($"\nPlease Enter the {i} number : ");
				string temp = Console.ReadLine();

				if (Decimal.TryParse(temp, out result) && result <= 100 && result >= 0)
				{
					return result;
				}
			}
		}

		// static console printing method
		public static void PrintOptions()
		{
			Console.WriteLine("\n\n======== Options ========");
			Console.WriteLine("1 - Aggregate");
			Console.WriteLine("2 - Min marks");
			Console.WriteLine("3 - Max marks");
			Console.WriteLine("4 - Grade");
			Console.WriteLine("0 - Exit");
			Console.WriteLine("=========================");

			Console.Write("Enter your Choice");
		}

		// further options for user
		public static void TakingInputFromUserForFurtherProcess(Student student)
		{
			int x = 1;

			// checking condition
			while (x != 0)
			{
				PrintOptions();

				try
				{
					x = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					x = 6;
				}
				switch (x)
				{
					case (int)Options.Aggregate:
						student.AggrigateFunc();
						break;
					case (int)Options.MinMark:
						student.MinMarkFunc();
						break;
					case (int)Options.MaxMark:
						student.MaxMarkFunc();
						break;
					case (int)Options.Grade:
						student.PrintGradeFunc();
						break;
					case 0:
						break;
					default:
						Console.WriteLine("wrong option chosen");
						break;
				}
			}
		}

	}
}