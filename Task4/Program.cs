// Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

void Main()
{
    System.Console.Write("Введите число в диапазоне от 1 до 100000: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int temp;
    int sizeArray = SizeOfArray(number);
    int[] array = new int[sizeArray];
    int[] array2 = new int[sizeArray];
    if(number > 0 && number < 100000)
    {
        System.Console.Write($"{number} => [");
        while(number > 0)
        {
            array[count] = number % 10;
            number = number / 10;
            array2[array2.Length - count - 1] = array[count];
            System.Console.Write($"{array[count]}");
            count++;
            if(number != 0) System.Console.Write(", ");
        }
        System.Console.Write($"]");
        count = 0;
        temp = 0;
        while(count <= sizeArray/2)
        {
            temp = array[count];
            array[count] = array[sizeArray - count - 1];
            array[sizeArray - count - 1] = temp;
            count++;
        }
        count = 0;
        System.Console.Write($"[");
        for(int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
        System.Console.WriteLine($"]");
    }
    else System.Console.WriteLine("Число вне диапазона");
}

int SizeOfArray(int number)
{
    int size = 0;
    while(number > 0)
    {
        number = number /10;
        size++;
    }
    return size;
}

Main();

