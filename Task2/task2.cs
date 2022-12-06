using System;
class task2

{
    static void Main()
    {

        string str = "abcdefghijklmnop"; 
        for (int i = 1; i < str.Length; i += 2) 
        { 
            Console.WriteLine(str[i]); 
        } 
        Console.ReadKey();

    }

}