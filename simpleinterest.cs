using System;

class program{

static void Main(){

Console.WriteLine("principle");
double p= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("rate");
double r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("time");
double t = Convert.ToDouble(Console.ReadLine());

double SI = p*r*t/100;
Console.WriteLine("SI:",SI);
}
}