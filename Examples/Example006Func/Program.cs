using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string Method4(int count, string cc) {
  int i = 0;
  string result = String.Empty; 
  return cc;
}


for (int i = 2; i <= 10; i++) {
  for (int j = 2; j <= 10; j++) {
    Console.WriteLine($"{i} x {j} = {i * j}");
  }
  Console.WriteLine();
}


void printArr(int[] forPrint) {
  foreach (int el in forPrint) {
    Console.WriteLine(el);
  }
};

int[] arr1 = {1, 2};
printArr(arr1);



string username = Console.ReadLine();

Console.WriteLine("Hello," + username);


