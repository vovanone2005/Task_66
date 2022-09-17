int a = InputNumbers("Введите a: ");
int count = 2;
PrintNumber(a, count);
Console.Write(1);

void PrintNumber(int a, int count)
{
  if (count > a) return;
  PrintNumber(a, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}