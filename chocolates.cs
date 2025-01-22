/* using System;

class chocolates{
	
	static int getchocolates(int totalChoclates, int children){
		return totalChoclates/children;
	}
	static int leftchocolates(int totalChoclates, int children){
		return totalChoclates%children;
	}
		
		
	static void Main(){
		Console.Write("total no of chocolates");
		int totalChoclates = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("no of Children");
		int children = Convert.ToInt32(Console.ReadLine());
		
		int Eachchildern = getchocolates(totalChoclates, children);
		
		int Remaining = leftchocolates(totalChoclates, children);
		
		Console.Write($"The number of chocolates each child gets is {Eachchildern} and the number of remaining chocolates is {Remaining}");
	}
	
}
		 */