Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = 0;
int a2 = 0;
    if (a < 100 ){
        Console.WriteLine("Третьей цифры нет");
    }
    else if (a > 999){
        Console.WriteLine("Вы ввели некоректное число");
    }
    else {
         a1 = a % 10;

    }

        Console.Write($"Последняя цифра числа {a}: {a1}");
    

