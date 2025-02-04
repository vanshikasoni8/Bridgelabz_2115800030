/* public class NumberChecker {
	
	//The function is used to count number of digits in a number
	private static int countDigit(int num) {
		int res = 0;
		while(num > 0) {
			res++;
			num /= 10;
		}
		
		return res;
	}
	
	//The function is used to store all the digits of a number in an array
	private static int[] Store(int num) {
		int cnt = countDigit(num);
		
		int[] arr = new int[cnt];
		int idx = 0;
		
		while(num > 0) {
			int rem = num % 10;
			arr[idx++] = rem;
			num /= 10;
		}
		
		return arr;
	}
	
	//The function is used to check wether a number is a Duck Number
	private static bool DuckNumber(int[] arr) {
		foreach(int i in arr) {
			if (i != 0)
				return true;
		}
		
		return false;
	}
	
	//The function is used to check wether a number is an Armstrong Number
	private static bool Armstrong(int num, int[] arr) {
		int res = 0;
		foreach(int i in arr) {
			res += i * i * i;
		}
		
		return res == num ? true : false;
	}
	
	//The function is used to find largest and 2nd largest digits of a number
	private static (int, int) Largest(int[] arr) {
		int max = int.MinValue;
		int max2 = int.MinValue;
		
		foreach(int i in arr) {
			if(i > max) {
				max2 = max;
				max = i;
			} else if(i < max && i > max2) {
				max2 = i;
			}
		}
		
		return (max, max2);
	}
	
	//The function is used to find smallest and 2nd smallest digits of a number
	private static (int, int) Smallest(int[] arr) {
		int min = int.MaxValue;
		int min2 = int.MaxValue;
		
		foreach(int i in arr) {
			if(i < min) {
				min2 = min;
				min = i;
			} else if(i > min && i < min2) {
				min2 = i;
			}
		}
		
		return (min, min2);
	}
	  
	
	public static void Main(string[] args) {
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		int cnt = countDigit(num);
		int[] arr = Store(num);
		bool duck = DuckNumber(arr);
		bool armStrong = Armstrong(num, arr);
		(int min, int min2) = Smallest(arr);
		(int max, int max2) = Largest(arr);
		
		Console.WriteLine($"No of Digits: {cnt}");
		Console.WriteLine($"Is {num} a Duck Number: {duck}");
		Console.WriteLine($"Is {num} an Armstrong Number: {armStrong}");
		Console.WriteLine($"Smallest -> {min} and 2nd Smallest {min2}");
		Console.WriteLine($"Largest -> {max} and 2nd Largest {max2}");
		
	}
} */