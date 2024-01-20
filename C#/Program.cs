
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

int choice = 0;

while(choice != 4)
{
    Console.WriteLine($"Введите номер задания ");
    Console.WriteLine($" 1 первое задание ");
    Console.WriteLine($" 2 второе задание ");
    Console.WriteLine($" 3 третье задание ");
    Console.WriteLine($" 4 выход ");
    choice = Convert.ToInt32(Console.ReadLine());
    // первое задание
    if (choice == 1) 
    {
        bool result = false;
        while (result == false)
        {
            Console.WriteLine("Введити число или q");
            object input = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(input);
                if (SumNum(num) % 2 == 0)
                {
                    result = true;
                }
            }
            catch 
            {
                char chr = Convert.ToChar(input);
                
                if (chr == 'q')
                {
                    result = true;
                }
            }
        }
        Console.WriteLine("проверка 1 заданеия завершена");
    }
    //второк задание
    if (choice == 2)
    {
        Console.WriteLine("Введити размер случайного массива ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введити минимальное значение элемента ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введити максимальное значение элемента ");
        int max = Convert.ToInt32(Console.ReadLine());
        int [] arr = CreateRndArray(size, min, max);
        Console.WriteLine("Массив:");
        WriteArray(arr);
        Console.WriteLine("Четных элементов:");
        Console.WriteLine(CountEvenInArray(arr));
    }
    //третье задание
    if (choice == 3)
    {
        Console.WriteLine("Введити размер случайного массива ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введити минимальное значение элемента ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введити максимальное значение элемента ");
        int max = Convert.ToInt32(Console.ReadLine());
        int [] arr = CreateRndArray(size, min, max);
        Console.WriteLine("Массив:"); 
        Console.WriteLine("");
        WriteArray(arr);
        int [] revarr = ReverseArray(arr);
        Console.WriteLine("");
        Console.WriteLine("Обратный массив: ");
        WriteArray(revarr); 
     
    }

}
Console.WriteLine("end");

