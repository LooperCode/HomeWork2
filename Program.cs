Console.WriteLine("Введите минимум трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = 0;
int temp = a;
    if (a <= 99 ){
        Console.WriteLine("Третьей цифры нет");
    
    }
    else if (a < 999){
        a1 = a % 10;
    }
    
    else {
        while (a > 999) {
            a = a / 10;
            a1 = a%10;
        }
    }
Console.WriteLine($"Третья цифра числа {temp}: {a1}");
    