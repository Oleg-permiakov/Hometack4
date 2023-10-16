// Программа которая принимает три числа и выдаёт наибольшее из них
Console.WriteLine("Введите первое число");
string namb = Console.ReadLine();
int namber1 = Convert.ToInt32(namb);

Console.WriteLine("Введите второе число");
string namb2 = Console.ReadLine();
int namber2 = Convert.ToInt32(namb2);

Console.WriteLine("Введите третье число");
string namb3 = Console.ReadLine();
int namber3 = Convert.ToInt32(namb3);

int result = namber1;
     if (namber2 > result) result = namber2;
     if (namber3 > result) result = namber3;
     Console.WriteLine(result);