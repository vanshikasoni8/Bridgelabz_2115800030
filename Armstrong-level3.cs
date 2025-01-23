/* using System;

class Armstrong{
	//method to find the sum to the toal digit with each digit's cube
	static int checkArmstrong(int number){
		int sum =0 ; 
		while(number !=0){
			int digit = number %10 ;
			int power = (int)Math.Pow(digit,3);
			sum += power;
			
			number/=10;
		}
		return sum;
	}
	
	static void Main(){
		// user input 
		Console.Write("enter the number");
		int Orignalnumber = int.Parse(Console.ReadLine());
		//initializing the orignal number to a new variable
		int number = Orignalnumber;
		
		// calling function 
		int check = checkArmstrong(number);
		
		// checking whether its same se qrignal number or not
		if(check ==Orignalnumber){
			Console.Write("its an Armstrong Number");
		}
		else{
			Console.Write("Not an Armstrong Number");
		}
	}
}


 */