using System;

namespace PopulationGrowth
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Double pop, grow, year;
			
			Console.WriteLine("Please enter an initial population:");		
			pop = Convert.ToDouble(Console.ReadLine());
			
			while (pop < 1){
				Console.WriteLine("Please enter an initial population:");
				Console.WriteLine("Note: Initial Population cannot be less than 1");	
				pop = Convert.ToDouble(Console.ReadLine());
			}
			
			
			Console.WriteLine("Please enter the percent growth:");
			grow = Convert.ToDouble(Console.ReadLine());
			
			while (grow < 1 || grow > 100){				
				
					Console.WriteLine("Please enter the percent growth:");
					Console.WriteLine("Note: Growth must be greater than 1 and Less than 100");
					grow = Convert.ToDouble(Console.ReadLine());
									
			}
			
			Console.WriteLine("Please enter the number of years:");
			year = Convert.ToDouble(Console.ReadLine());
			
			while (year < 1){
				Console.WriteLine("Please enter the number of years:");
				Console.WriteLine("Note the number of years cannot be less than 1");
				year = Convert.ToDouble(Console.ReadLine());
			}
			
			 int popgrow = Convert.ToInt32((pop *year) + ((grow/100) * pop));
			
		Console.WriteLine("The Population growth for {0} Years is: {1}",year, popgrow);
		Console.ReadKey();
			
		}
	}
}
