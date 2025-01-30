/* using System;

class VowelsConsonents{
	
	static void Main(string[] args){
		Console.Write("enter the string");
		 string input = Console.ReadLine();
		
		
		int vowels =0 ; 
		int consonents =0 ;
		
		foreach(char ch in input){
			if(char.IsLetter(ch)){
				if("aeiouAEIOU".Contains(ch)){
					vowels++;
				}
				else{
					consonents++;
				}
			}
		}
		Console.Write($"No.of Vowels : {vowels}");
		Console.Write($"No.of Consonents: {consonents}");
	}
}
		
		 */