/* using System;
class DiscountPercent
{
    static void Main()
    {  
       // user input for fee
        Console.Write("Enter the fee: INR ");
        Double fee = double.Parse(Console.ReadLine());


        // user input for discount percentage
        Console.Write("Enter the discount percentage: ");
        Double discountPercent = double.Parse(Console.ReadLine());


        // Calculate discount amount
        double discount = (fee * discountPercent) / 100;


        // Calculate final discounted fee
        double discountedFee = fee - discount;


        // Display the result
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
}
 */