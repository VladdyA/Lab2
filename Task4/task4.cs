using System;
class task4

{
    static void Main()
    {
      int num; 
      int sum = 0; 
      int count = 0; 
      do 
      { 
          num = Convert.ToInt32(Console.ReadLine()); 
          sum += num; 
          count++; 
      } 
      while (num > 0); 

      double avarage = (double)(sum) / (count - 1); 
      Console.WriteLine(avarage); 
      Console.ReadKey();
    }

}