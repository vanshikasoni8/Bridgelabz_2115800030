/* using System;


class EarthVolume
{
    static void Main()
    {
        // Radius of Earth in kilometers
        double radiusKm = 6378;


        // the volume in cubic kilometers (V = 4/3 * pi * r^3)
        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);


        // Converting cubic kilometers to cubic miles (1 km^3 = 0.239913 cubic miles)
        double volumeMiles = volumeKm * 0.239913;


        // Display the result
        Console.WriteLine($"The volume of Earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
    }
}
 */