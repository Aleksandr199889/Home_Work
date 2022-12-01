Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());
int[ ] array = {num1, num2, num3};
int n = array.Length;
int index = 0;
int max = num3;
while (index < n)
{
    if (array[index] > max)
    {
        max = array[index];
    }
    index++;
}
Console.WriteLine(max);
