using System;
class task3

{
    static void Main()
    {
        string drink = Console.ReadLine(); 
                switch (drink) 
                { 
                    case "Coffee": 
                    case "coffee": 
                    case "Кава": 
                    case "кава": 
                        Console.WriteLine("50 грн"); 
                        break; 
                    case "Tea": 
                    case "tea": 
                    case "Чай": 
                    case "чай": 
                        Console.WriteLine("45 грн"); 
                        break; 
                    case "Juice": 
                    case "juice": 
                    case "Сік": 
                    case "сік": 
                        Console.WriteLine("30 грн"); 
                        break; 
                    case "Watter": 
                    case "watter": 
                    case "Вода": 
                    case "вода": 
                        Console.WriteLine("20 грн"); 
                        break; 
                } 
                Console.ReadKey();
    }

}