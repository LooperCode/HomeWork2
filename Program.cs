Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = 0;
int a2 = 0;
    if (a < 100 ){
        Console.WriteLine("Вы ввели некорректное число");
    }
    else if (a > 999){
        Console.WriteLine("Вы ввели некоректное число");
    }
    else {
         a1 = a / 100;
         a2 = a % 100;
         a2 = a2 / 10;
    }

        Console.Write($"Вторая цифра числа {a}: {a2}");
    

