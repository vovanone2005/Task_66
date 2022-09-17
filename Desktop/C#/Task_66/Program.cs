int a = InputNumbers("Введите a: ");
int b = InputNumbers("Введите b: ");
int temp = a;

if (a > b) 
{
  a = b; 
  b = temp;
}


PrintSumm(a, b, temp=0);

void PrintSumm(int a, int b, int summ)
{
  summ = summ + b;
  if (b <= a)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(a, b - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
