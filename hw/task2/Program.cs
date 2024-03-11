//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



int AkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkermanFunc(m - 1, AkermanFunc(m, n - 1));
    }
    return -1;

}

Console.Write(AkermanFunc(0, 2));