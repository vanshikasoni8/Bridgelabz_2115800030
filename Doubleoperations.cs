/* using System;

class Doubleoperations{
	
	//for first operation a + b * c
	static double getoperation1(double a, double b , double c){
		return a + b * c;
	}
	
	//for secondoperation a + b * c
	static double getoperation2(double a, double b ,double c){
		return a * b + c;
	}
	
	//for third operation a + b * c
	static double getoperation3(double a, double b ,double c){
		return c + a / b;
	}
	
	//for fourth operation a + b * c
	static double getoperation4(double a , double b ,double c){
		return  a % b + c;
	}
	
	static void Main(){
		
		
		Console.Write("input of a"); // taking input a
		double a = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("input of b");// taking input b
		double b = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("input of c ");// taking input c
		double c = Convert.ToDouble(Console.ReadLine());
		
		double operation1 = getoperation1(a,b,c);
		double operation2 = getoperation2(a,b,c);
		double operation3 = getoperation3(a,b,c);
		double operation4 = getoperation4(a,b,c);
		
		Console.Write($"The results of double Operations are {operation1},{operation2},{operation3} and {operation4}");
	}
	

		
		
	}
	 */