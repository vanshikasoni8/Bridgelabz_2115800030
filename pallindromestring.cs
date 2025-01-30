/* using System;

class palindromestring{
	
	static void Main(){
		Console.Write(" enter te string : ");
		string input = Console.ReadLine();
		bool flag =true;
		for(int i=0 ,j= input.Length-1 ;  i<input.Length/2 ; i++ ,j--){
			
			if(input[i] != input[j]){
				//Console.Write("not Palindrome");
				flag=false;
				break;
			}
			
		}
		if(flag){
			Console.Write("Palindrome");
		}
		else{
			Console.Write("not Palidrome");
		}
		
	}
}

		
 */