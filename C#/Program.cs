

int [] CreateRndArray(int size, int min, int max)
{    
    int [] array = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);        
    }    
    return array;    
}

int [] ReverseArray(int [] array)
{
    int mem = 0;
    int len = array.Length;
    for (int i = 0; i < len / 2; i++)
    {
        mem = array[i];
        array[i] = array[len - i - 1];
        array[len - i - 1] =  mem;        
    }
    return array;
}

void WriteArray (int [] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int [] CreateConsoleReadArr()
{
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt32(Console.Read());
    Console.WriteLine("Введите значения ");
    int i = 0;
    int [] arr = new int [size];
    while (i < size)
    {
        Console.WriteLine("Введите значения ");
        arr[i] = Convert.ToInt32(Console.Read());
        i++;
    }
    foreach(int e in arr)
    {
        Console.WriteLine(e);
    }
    return arr;
}

int SumNum (int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int CountEvenInArray(int [] array)
{
    int count = 0;
    foreach(int i in array)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


while(num % 2 == 0 &&)