/* using System;

public class OTPGenerator {
    //Method to generate a 6-digit OTP
    private static int GenerateOTP() {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    //Method to generate an array of 10 OTPs
    private static int[] GenerateOTPs(int count) {
        int[] otps = new int[count];
        for (int i = 0; i < count; i++) {
            otps[i] = GenerateOTP();
        }
        return otps;
    }

    //Method to check if all OTPs in the array are unique
    private static bool AreOTPsUnique(int[] otps) {
        for (int i = 0; i < otps.Length; i++) {
            for (int j = i + 1; j < otps.Length; j++) {
                if (otps[i] == otps[j]) {
                    return false; 
                }
            }
        }
        return true;
    }

    public static void Main(string[] args) {
        const int otpCount = 10;

        int[] otps = GenerateOTPs(otpCount);

        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps) {
            Console.WriteLine(otp);
        }

        bool areUnique = AreOTPsUnique(otps);
        Console.WriteLine($"\nAre all OTPs unique? {areUnique}");
    }
}
 */