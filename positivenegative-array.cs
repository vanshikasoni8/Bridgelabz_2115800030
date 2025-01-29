/* using System;

class positivenegativearray{
	
	static void Main(){
		
		Console.WriteLine(" Enter number to find that the Number is Positive or Negative ");
		// array intialization
		int [] number = new int[5];
		
		
		// for storing the input the array 
		for(int i=0 ; i<number.Length ; i++){
			
			Console.WriteLine($"enter the number{i+1} : " );
			int input = Convert.ToInt32(Console.ReadLine());
			
			number[i] = input ;
		}
		
		//for checking the number is positive, negative and Zero
		for(int i=0 ; i<number.Length ; i++){
			int input = number[i];
			if(input>0){
				if(input%2 ==0){
					Console.WriteLine($"{input} is even and positive");
				}
				else{
					Console.WriteLine($"{input} is odd and positive");
				}
			}
			else if(input<0){
				if(input%2 ==0){
					Console.WriteLine($"{input} is even and negative");
				}
				else{
					Console.WriteLine($"{input} is odd and negative");
				}
			}
			else{
				Console.WriteLine($"{input} is Zero");
			}
		}
		
		int first = number[0];
		int last = number[^1];
		
		// compare first and last values
		if(first ==last){
			Console.WriteLine("first and last are equal");
		}
		else if(first<last){
			Console.WriteLine("first is smaller than last");
		}
		else{
			Console.WriteLine("First is bigger than last");
		}
		
	
	}
}
		 */