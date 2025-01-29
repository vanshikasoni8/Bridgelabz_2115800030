/* using System;

class vote{
	
	static void Main(){
		int[] agestudent = new int[10];
		
		Console.WriteLine("enter the ages of student");
		
		for(int i= 0 ; i<agestudent.Length; i++){
			Console.Write($"enter the age of {i+1} student");
			int age = Convert.ToInt32(Console.ReadLine());
			
			
			agestudent[i] =age ;
		}
		for (int i = 0; i < agestudent.Length; i++)
        {
            int age = agestudent[i];

            if (age < 0)
            {
                Console.WriteLine($"Student {i + 1}: Invalid age.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"Student {i + 1}: The student with the age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"Student {i + 1}: The student with the age {age} cannot vote.");
            }
        }
	}
} 


 */