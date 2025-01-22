using System;

class program{

static void Main(){

Console.WriteLine("length:");
double l = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Breadth");
double b = Convert.ToDouble(Console.ReadLine());

double perimeter = 2*(l+b) ;
Console.WriteLine(perimeter);

}
}