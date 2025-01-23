/* using System;

class SpringSeason{
	
	static void Main(){
		
		Console.Write("enter the date number");
		int month = int.Parse(Console.ReadLine());
		
		Console.Write("enter the date number");
		int day = int.Parse(Console.ReadLine());
		
		//condition statement
		bool isSpring = (month == 3 && day >= 20 && day <= 31) || // March 20-31
                        (month == 4 && day >= 1 && day <= 30) ||  // April 1-30
                        (month == 5 && day >= 1 && day <= 31) ||  // May 1-31
                        (month == 6 && day >= 1 && day <= 20);    // June 1-20
		
		//if else condition 
		if (isSpring)
		{
			Console.Write("It's spring Season");
		}
		else{
			Console.Write("Not a spring Season");
		}
	}
}
 */