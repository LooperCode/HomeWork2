﻿Console.WriteLine("Введите минимум трехзначное число до ''999999''");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = 0;

    if (a < 100 ){
        Console.WriteLine("Третьей цифры нет");
    
    }
    
    else if (a <= 999){
        
        a1 = a % 10;
        Console.Write($"Третья цифра числа {a}: {a1}");
    }
    else if (a <= 9999) {
        a1 = a % 100;
        a1 = a1 / 10;
        Console.Write($"Третья цифра числа {a}: {a1}");
    }    
        
    else if (a <= 99999) {
         
         a1 = a / 100;
         a1 = a1 % 10;
        Console.Write($"Третья цифра числа {a}: {a1}");
    }

     else {
        a1 = a / 1000;
        a1 = a1 % 10;
        Console.Write($"Третья цифра числа {a}: {a1}");
     }   
    

