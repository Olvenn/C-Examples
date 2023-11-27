Console.WriteLine("Hello, World!");

static void CheckIfDivisible7And23(int number)
    {
      if (number % 7 == 0 & number % 23 == 0 ) {
        Console.WriteLine($"This, {number} is multiples of 7 and 23.");
      } else {
        Console.WriteLine($"This, {number} is not multiples of 7 and 23.");      }
    }
  
CheckIfDivisible7And23(162);

static void ChecNumberOfCoordinateQuarter(int x, int y)
    {
      if (x > 0) {
        if (y > 0) {
          Console.WriteLine("Coordinate quarter - 1");
        } else {
          Console.WriteLine("Coordinate quarter - 4");
        }
      }
      if (x < 0) {
        if (y > 0) {
          Console.WriteLine("Coordinate quarter - 2");
        } else {
          Console.WriteLine("Coordinate quarter - 3");
        }
      }
    }

ChecNumberOfCoordinateQuarter(2, 3);
ChecNumberOfCoordinateQuarter(-2, 3);
ChecNumberOfCoordinateQuarter(-2, -3);
ChecNumberOfCoordinateQuarter(2, -3);

static void maxDigit(int number)
    {
      if (number < 10 | number > 99) {
        Console.WriteLine("Invalid number.");
      } else {
        int first = number / 10;
        int second = number % 10;

        if (first > second) {
          Console.WriteLine($"The largest digit {first}");
        } else {
          Console.WriteLine($"The largest digit {second}");
        }
      }
    }
  
maxDigit(270);
maxDigit(27);

static void printNumbersDigits(int number)
    {
      if (number < 1) {
        Console.WriteLine("Invalid number.");
      } else {
        while (number / 10 > 0) {
          Console.Write($"{number % 10}, ");
          number /= 10;
        }
        }
          Console.WriteLine(number);
    }
  
printNumbersDigits(270);

static void printNumbersDigits2(int number)
    {

      if (number < 1) {
        Console.WriteLine("Invalid number.");
      } else {
        while (number / 10 > 0) {
          Console.Write($"{number % 10}, ");
          number /= 10;
        }
      }
        Console.WriteLine(number);
    }
    
  
printNumbersDigits2(270);