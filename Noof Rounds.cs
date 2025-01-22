/* using System;

class rounds{
	// function of counting the no of rounds
	static int totalrounds(int side1,int side2,int side3){
		int distance = 5000;
		return distance /(side1+ side2 +side3);
	}
	
	static void Main(){
		// length of side one of traingle park
		Console.Write("side 1 ");
		int side1 = Convert.ToInt32(Console.ReadLine()); 
		
		// length of side second of traingle park
		Console.Write("side 2 ");
		int side2 = Convert.ToInt32(Console.ReadLine()); 
		
		// length of side third of traingle park
		Console.Write("side 3");
		int side3 = Convert.ToInt32(Console.ReadLine()); 
		
		//calling function 
        int NoOfRounds = totalrounds(side1, side2, side3);
		
		//display the output
		Console.Write($" No. of rounds {NoOfRounds}");
	}
}
		 */