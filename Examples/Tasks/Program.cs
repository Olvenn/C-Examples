// Console.WriteLine("Hello, World!");
// int num = 456;
// int first = num / 100;
// int second = num % 10;
// int third = num % 100;
// Console.WriteLine($"{first} {second} {third}");
// double middle = (num % 100 - num % 10) / 10;
// double last = num % 10;

// double pow = Math.Pow(middle, last);

// Console.WriteLine($"{pow}");

// На вход два числа. Является ли второе число кратным первому.

// int first = 156;
// int second = 11;

// if (first % second == 0) {
//     Console.WriteLine("да");
// } else {
//     Console.WriteLine($"нет, {first % second}");
// }

// На вход число. Если есть третья цифра выводим (7812 -> 1), если нет Третьей цифры нет.

int num = 114561;
if (num < 0) {
  num *= (-1);
}
if (num / 100 < 0) {
   Console.WriteLine("Третьей цифры нет");
} else if (num / 100 < 10) {
     Console.WriteLine($"{num % 10}");
} else {
  while (num / 100 > 10) { // (num > 999)
    num /= 10;
  }
  Console.WriteLine($"{num % 10}");
}

        // string str = num.ToString();
        // Console.WriteLine(str[1]);