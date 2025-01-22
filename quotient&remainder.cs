using System;{

class quotien&remainder{

static void main(){

Console.Write("number1");
int number1= Convert.Int32(Read.Line());

Console.Write("number2");
int number2 = Convert.Int32(Read.Line());

int quotient = number1 /number2;

int reaminder = number1%number2;

Console.WriteLine("Quotient of {number1} and {number2} is {quotient}");
Console.WriteLine("Remainder of {number1} and {number2} is {quotient}");
