// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9, 10);
    }
    return arr;
}



System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(",", array));

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isOk = false;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        isOk = true;
        break;
    }
}
if (isOk)
{
    System.Console.WriteLine("Элемент найден");
}
else
{
        System.Console.WriteLine("Элемент не найден");
}