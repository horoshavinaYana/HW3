//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да


int GetReverse(int Value)
{
    int ValueTMP = Value;
    int Reverse = 0;
    while (ValueTMP > 0)
    {
        Reverse = Reverse * 10 + ValueTMP % 10;
        ValueTMP /= 10;
    }
    return Reverse;
}

Console.WriteLine("Введите палиндром");
int Value = Convert.ToInt32(Console.ReadLine());
int Reverse = GetReverse(Value);
 if (Value == Reverse)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }