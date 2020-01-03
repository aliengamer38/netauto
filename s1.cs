using System;

public class Program
{
  static void Main()
  {
    if (int.TryParse(Console.ReadLine(), out int input))
    {
      input += 10;
    }
    Console.ReadLine($"The value of input is {input}");
  }
}
