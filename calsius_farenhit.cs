using System;

class program{

static void Main(){

Console.WriteLine(" Temp in celsius");
double calsius = Convert.ToDouble(Console.ReadLine());

double farenhit = (calsius * 9/5) +32;

Console.WriteLine(farenhit);
}
}