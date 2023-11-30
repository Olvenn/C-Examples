using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void FillArray(int[,] matr) {
  for (int i = 0; i < matr.GetLength(0); i++) {
    for (int j = 0; j < matr.GetLength(1); j++) {
    Random rnd = new Random();
    matr[i, j] = rnd.Next(1, 10);
    }
    Console.WriteLine();
  }
}

void PrintArray(int[,] matr) {
  for (int i = 0; i < matr.GetLength(0); i++) {
    for (int j = 0; j < matr.GetLength(1); j++) {
    Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}


int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);

char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
string s2 = new String(ch_array);
string s3 = new String('a', 6); // "aaaaaa"

void PrintImage(int[,] image) {
  for (int i = 0; i < image.GetLength(0); i++) {
    for (int j = 0; j < image.GetLength(1); j++) {
    // Console.Write($"{matr[i, j]} ");
    if (image[i, j] == 0) Console.Write($" ");
    else Console.Write($"+");
    }
    Console.WriteLine();
  }
}

int[,] pic = new int[,]
{

  {1, 1, 1, 1, 1, 1, 1},
  {1, 1, 0, 0, 0, 1, 1},
  {1, 1, 0, 0, 0, 1, 1},
  {1, 0, 0, 0, 0, 0, 1},
  {1, 1, 0, 0, 0, 1, 1},
  {1, 1, 0, 0, 0, 1, 1},
  {1, 1, 1, 1, 1, 1, 1},

};



void FillImage (int row, int col) {
  if (pic[row, col] == 0) {
    {
      pic[row, col] = 0;
      FillImage (row - 1, col);
      FillImage (row, col-1);
      FillImage (row + 1, col);
      FillImage (row, col + 1);
    }
  }
}
PrintImage(pic);
FillImage(3, 4);
PrintImage(pic);