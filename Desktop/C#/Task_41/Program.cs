Console.Write($"Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < Numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(Numbers)} ");