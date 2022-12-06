using System;
class task8

{
    static void Main()
    {

        string golosni = Console.ReadLine(); 
             int a_gl = 0; 
             int o_gl = 0; 
             int i_gl = 0; 
             int e_gl = 0; 
  
             for( int g = 0; g < golosni.Length; g++) 
             { 
                 switch(golosni[g]) 
                 { 
                     case 'a': 
                     case 'а': 
                         a_gl += 1; 
                         break; 
                     case 'o': 
                     case 'о': 
                         o_gl += 1; 
                         break; 
                     case 'i': 
                     case 'і': 
                         i_gl += 1; 
                         break; 
                     case 'e': 
                     case 'е': 
                         e_gl += 1; 
                         break; 
                 } 
             } 
             Console.WriteLine($"a: {a_gl} o: {o_gl} i: {i_gl} e: {e_gl}"); 
             Console.WriteLine($"Їх сума: {a_gl + o_gl + i_gl + e_gl}"); 
    }

}