using System;

namespace SemesterHours
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int hours;
			
			Console.WriteLine ("Please enter the number of credit hours you are taking this semester:");
			hours = Convert.ToInt32(Console.ReadLine());
			
			if (hours == 0)
				Console.WriteLine ("Unqualified: Not a student");
			else if (hours > 0 && hours <= 11)
				Console.WriteLine ("Part-time student");
			else if (hours > 11 && hours <= 18)
				Console.WriteLine("Full-time student");
			else if (hours > 18)
				Console.WriteLine("Overloaded student");
			else
				Console.WriteLine("Please Enter the correct input.");
			
			Console.ReadKey();
		}
	}
}
