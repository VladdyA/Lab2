using System;
class task7

{
    static void Main()
    {
      string num = Console.ReadLine(); 
             int count = 0; 
             foreach (char p in num) 
             { 
                 if (p % 2 != 0) 
                     count++; 
                 else 
                     break; 
             } 
             if (count == num.Length) 
                 Console.WriteLine("Всi числа є непарними"); 
             else 
                 Console.WriteLine("Не всi числа є непарними");


    }

}