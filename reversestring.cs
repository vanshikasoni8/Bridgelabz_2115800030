/* using System;

class reverseString{
	
	static void Main(){
		Console.Write("enter the string: ");
		string input = Console.ReadLine();
		
		char[] reverse = new char[input.Length];
		for(int i = 0,j= input.Length-1 ; i<input.Length ;i++ , j--){
			reverse[i] = input[j];
			
		}
		for(int i=0 ; i< reverse.Length ;i++){
			Console.Write( reverse[i] );
		}
	}
}

			 */