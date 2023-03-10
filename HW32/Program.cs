//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int[] GetCoordinate()
{
    int[] Coordinate = new int[3];
    Console.WriteLine("Введите x-кординату");
    Coordinate[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y-кординату");
    Coordinate[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите z-кординату");
    Coordinate[2] = Convert.ToInt32(Console.ReadLine());
    return Coordinate;
}

double GetDistanceBetweenTwoPoints(int[] A, int[] B)
{
    return Math.Sqrt( Math.Pow((B[0] - A[0]),2) 
                    + Math.Pow((B[1] - A[1]),2) 
                    + Math.Pow((B[2] - A[2]),2) );
}

Console.WriteLine("Введите первую точку");
int[] A = GetCoordinate( );
Console.WriteLine("Введите вторую точку");
int[] B = GetCoordinate( );
Console.WriteLine($"Расстояние:{GetDistanceBetweenTwoPoints(A,B).ToString("N2")}");