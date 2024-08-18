// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

// задаём массив
double[] array = new double[] {1.38, 13.32, 45.1, 23.94, 64.43, 20.02, 39.72, 90.10, 95.84, 47.2};
// переменная для максимального элемента
double maxElement = array[0];
// переменная для минимального элемента
double minElement = array[0];
// цикл для перебора элементов массива
foreach(double number in array)
{
    // поиск максимального и минимального элементов
    if(number > maxElement)
        maxElement = number;
    if(number < minElement)
        minElement = number;
}
// переменная для результата разности элементов
double result = maxElement - minElement;
System.Console.WriteLine(result);
