int numberA = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine(numberB);
int result = numberA |+ numberB;
Console.WriteLine(result);

double numberADouble = 12;
double numberBDouble = 5;

Console.WriteLine(numberADouble / numberBDouble);

// Найти мах из 4 чисел

int a = 2;
int b = 5;
int c = 3;
int d = 1;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
Console.WriteLine("max = " + max);
