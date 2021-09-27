using System;
 class ConsoleApp
 {
     static void Main ()
     {
         Console.Write("Input digit: ");
         int n = int.Parse(Console.ReadLine());

         for (int i = 1;i<11;i++)
         {
             int dig=n;
             dig *=i;
             Console.WriteLine(i +"\t" + dig);
             dig = n;
         }
     }
 }
