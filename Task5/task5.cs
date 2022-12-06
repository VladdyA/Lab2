using System;
class task5
{
    static void Main()
    {
        int y; 
        y = Convert.ToInt32(Console.ReadLine());
        if (y % 4 == 0)
        {
            if ((y % 100 != 0) || ((y % 100 == 0) && (y % 400 == 0)))
                Console.WriteLine("Рiк високосний");
        }
        else
            Console.WriteLine("Рiк не високосний"); 
    }

}