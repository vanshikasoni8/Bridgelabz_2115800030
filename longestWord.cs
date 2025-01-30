/* using System;

class LongestWord{
	
	static void Main(){
		Console. Write("enter the sentence");
		string input = Console.ReadLine();
		Console.Write(findtheLongest(input));
		
	}
	static string findtheLongest(string input){
		string currentword = "";
		string longestword = "";
		int maxLength=0 ;
		
		foreach(char c in input  ){
			if(c!= ' '){
				currentword+=c;
			}
			else{
				if(currentword.Length >maxLength){
					maxLength=currentword.Length;
					longestword=currentword;
				}
				currentword="";
			}
		}
		if(currentword.Length>maxLength){
			longestword=currentword;
		}
		return longestword;
				
				
		//	if(word.Length> longestword.Length){
		//		longestword =word;
		//	}
		//}
		//return longestword;
	}
}
			 */