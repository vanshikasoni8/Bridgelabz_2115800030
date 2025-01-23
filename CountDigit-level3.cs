/* using System;

class Countdigits{
	
	//method for counting digits
	static int count(int initialnumber){
		int digits = 0; 
		
		while(initialnumber != 0){
			digits++;
			initialnumber/=10; 
			
		}
		return digits;
	}
	
	static void Main(){
		//user input
		Console.Write("enter the number");
		int number = int .Parse(Console.ReadLine());
		
		int initialnumber = number;
		
		// function calling
		int getcount = count(initialnumber);
		
		//output
		Console.Write(getcount);
	}
} */