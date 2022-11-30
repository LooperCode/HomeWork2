
int max = 0;
int max2 = 0;
int a = 1;


while (a != 0) {
Console.WriteLine(" Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a > 100){
    Console.WriteLine(" Не корректное число");
    break;
}

if (a > max) {
    max2 = max;
    max = a;
    
}
else if (a > max2) {
max2 = a;
}

Console.WriteLine($"Второе максимальное: {max2}");
}

