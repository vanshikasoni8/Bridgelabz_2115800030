/* using System;

class harshad{
	// function to get the sum of Digits
	static int SumofDigits(int number){
		int sum =0 ; 
		
		while(number!=0){
			int digit = number %10 ;
			sum += digit;
			
			number/=10;
		}
		return sum;
	}
	
	static void Main(){
		// user input of number
		Console.Write("enter number");
		int initialnumber = int .Parse(Console.ReadLine());
		int number = initialnumber;
		// function calling
		int finalSum = SumofDigits(number);
		
		//check no is harshad or not
		if (initialnumber%finalSum == 0){
		Console.Write("Harshad number");
		}
		else{
			Console.Write("Not a Harshad number");
		}
	}
}

			 */