using System; 
 
 class program{
 
 static void Main(){
 
 Console.WriteLine("radius of circle");
 double radius = Convert.ToDouble(Console.ReadLine());
 
 Console.WriteLine("height of Cylinder");
 double height = Convert.ToDouble(Console.ReadLine());
 
 double area = Math.PI * Math.Pow(radius,2) *height;
 
 Console.WriteLine(area);
 
 }
 }
 