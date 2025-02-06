//moneda//
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Random rand = new Random();
       int i = rand.Next(1, 3);
       if (i == 1) {
           Console.WriteLine("cara");
       } else { 
           Console.WriteLine("cruz");
       }
    }
}
