/* using System;

class abundantnumber{
	
	static void Main(){
		
		// user input of number
		Console.Write("enter number");
		int number = int .Parse(Console.ReadLine());
		int sum =0 ;

        // loop for getting the sum of divisors
		for(int i =1; i< number;i++){
			if(number % i ==0){
				sum+=i;
			}
		}
		//check if number is abundant or not
		if(sum>number){
			Console.Write("Abundant Number");
		}
		else{
			Console.Write("Not an Abundant Number");
		}
	}
}

			 */