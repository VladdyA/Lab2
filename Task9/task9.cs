using System;
class task9

{
    static void Main()
    {
        Console.WriteLine("Введiть номер мiсяця вiд 1 до 12(якщо високосний рiк введiть 2v)"); 
        string mounth = Console.ReadLine();
        switch (mounth)
        {
            case "1":
            case "3":
            case "5":
            case "7":
            case "8":
            case "10":
            case "12":
                Console.WriteLine("В цьому мiсяцi 31 день");
                break;
            case "4":
            case "6":
            case "9":
            case "11":
                Console.WriteLine("В цьому мiсяцi 30 днiв");
                break;
            case "2":
                Console.WriteLine("В цьому мiсяцi 28 днiв");
                break;
            case "2v":
                Console.WriteLine("В цьому мiсяцi 29 днiв");
                break;
        }
    } 

}