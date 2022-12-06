using System;
class task1

{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine()); 
                int b = Convert.ToInt32(Console.ReadLine()); 

                int count = 0; 
                int sum = 0; 
                for (int x = a; x < b; x++) 
                    if (x % 3 == 0) 
                    { 
                        count = count + 1; 
                    } 
                Console.WriteLine(count); 
                Console.ReadKey();


    }

}