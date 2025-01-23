/* using System;

class SumofnoUntil0{
	static void Main(){
		Console.Write("enter the nubmer");
		int num = int.Parse(Console.ReadLine());
		
		int sum =0;
		
		while(true){
			sum+=num;
			Console.Write("enter the nubmer ");
		    num = int.Parse(Console.ReadLine());
			if(num==0 || num<0){
				break;
			}
			else{
				continue;
			}
		}
		Console.Write($"the total sum of numbers are {sum}");
	}
} */