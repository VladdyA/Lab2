using System;
class task6

{
    static void Main()
    {
        string num = Console.ReadLine(); 
               int sum = 0; 

               foreach (char p in num) 
               { 
                   sum += Convert.ToInt32(p.ToString()); 
               } 
               Console.WriteLine(sum); 
               Console.ReadKey();

    }

}