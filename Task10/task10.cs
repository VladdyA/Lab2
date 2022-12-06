using System;
class task10

{
    static void Main()
    {
        int tenNum;
        int count = 0;
        int sum = 0;
        int mult = 1;
        int result = 0;
        for (var i = 0; i < 10; i += 1)
        {
            tenNum = Convert.ToInt32(Console.ReadLine());
            if (tenNum > 0)
            {
                count++;
            }
            if (i < 5)
            {
                sum += tenNum;
            }
            if (i < 4)
            {
                mult *= tenNum;
            }
            if (count == 10)
            {
                result = sum;
            }
            else if (count != 10)
            {
                result = mult;
            }
            Console.WriteLine(result);
        }

    }
}