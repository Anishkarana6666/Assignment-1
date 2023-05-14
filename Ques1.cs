using System;
     
public class TriangleProgram
{
 public static void Main()
 {
      Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());
 
	
            for (int i = 1; i <= n; i++)
   {
   
    for (int j = 1; j <= (n - i); j++)
    {
     Console.Write(" ");
    }
               
    for (int k = 1; k < i * 2; k++)
    {
     Console.Write("*");
    }
    Console.WriteLine();
   }
 }
}