// Время подсчёта работы программы по подсчёту числа Фибоначчи.

decimal fRec = 0; /* Переменная, которая будет считать количество вызовов рекурсии.*/
decimal fIte = 0; /* Переменная, которая будет считать количество итераций цикла.*/

//Рекурсивный метод.
decimal FibonacciRecurcion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecurcion(n - 1) + FibonacciRecurcion(n - 2);
}

//Итеративный метод.
decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

DateTime dt = DateTime.Now; /* Запомним время, которое было до начала подсчёта.*/
for (int n = 10; n < 40; n++)
{
    /* Выводим текстом (FibonacciIteration( {n})) значение (n), далее, само значение 
    ({FibonacciIteration(n)}) до какого числа мы считаем и сколько итераций цикла произошло.*/
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");

    fIte = 0; /* После того, как мы посчитали наше число, то мы его обнуляем для того, чтобы можно 
    было считать какое-то следующее.*/
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); /* Выведем на экран разницу между тем временем, 
которое получится после окончания посчёта и тем временем с которого подсчёт начался.*/

Console.WriteLine(); /* Пустая строка для отделения ответов.*/

dt = DateTime.Now; /* Запомним время, которое было до начала подсчёта.*/
for (int n = 10; n < 40; n++)
{
    /* Текстом (FibonacciIteration( {n})) значение (n), далее, само значение ({FibonacciIteration(n)}) 
    до какого числа мы считаем и сколько вызовов рекурсии произошло.*/
    Console.WriteLine($"FibonacciRecurcion( {n}) = {FibonacciRecurcion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0; /* После того, как мы посчитали наше число, то мы его обнуляем.*/
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); /* Выведем на экран разницу между тем временем, 
которое получится после окончания посчёта и тем временем с которого подсчёт начался.*/
