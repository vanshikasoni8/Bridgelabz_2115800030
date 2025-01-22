/* using System;

class travel{
	//function to get total Distance
	static int totaldistance(int FromToVai, int ViatoFinalcity ){
		return FromToVai + ViatoFinalcity;
	}		
	
	//function to get the total time
	static int Timeinminutes(int hours, int minutes){
		return hours*60  + minutes;
	}
	
	static void Main(){
		
		// input the name of the person
		Console.Write(" name of the person ");
		string name = Console.ReadLine();

        // name of the city person started
		Console.Write(" name of the city from where you have to start ");
		string fromcity = Console.ReadLine();
		
		// name of the city person via going
		Console.Write(" name of the city via you the going ");
		string viacity = Console.ReadLine();
		
		// name of the city person wants to reach
		Console.Write(" name of the city you want to reach ");
		string tocity = Console.ReadLine();
		
		// input distance between From to Via
	    Console.Write("Dinstance from to Via");
		int FromToVai = Convert.ToInt32(Console.ReadLine());
		
		// input distance between Via to finalcity
	    Console.Write("Dinstance Via to Final city");
		int ViatoFinalcity = Convert.ToInt32(Console.ReadLine());
		
		// time taken in hours to reach
	    Console.Write("Time taken in hours");
		int hours = Convert.ToInt32(Console.ReadLine());
		
		// time taken in minutes to reach
		Console.Write("In minutes");
		int minutes = Convert.ToInt32(Console.ReadLine());
		
		//calling functions to get the total distance and the total time
		int totalDistance = totaldistance(FromToVai, ViatoFinalcity);
		
		int totalTime = Timeinminutes(hours, minutes);

		
		// Print the travel details
      Console.WriteLine($"The Total Distance travelled by {name} from {fromcity} to {tocity} via {viacity} is {totalDistance} km and the Total Time taken is {totalTime} minutes");
    }
} 

 */