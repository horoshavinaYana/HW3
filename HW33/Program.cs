//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] Cube = new int[N];
for (int index = 0; index < N; index++)
{
    Cube[index] = Convert.ToInt32(Math.Pow((index + 1),3));
    Console.WriteLine(Cube[index]);
}