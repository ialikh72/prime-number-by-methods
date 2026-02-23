using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        isprime(num); 
            if(isprime(num))
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
        }
    }
    static bool isprime(int n)
    {
        bool isPrime = true;
        if(n<=1)
            isPrime = false;
        for(int i=2; i<=n/2; i++)
            if(n%i==0)
            return false;
        return true;
    }
}
