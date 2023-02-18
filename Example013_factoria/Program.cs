﻿// Метод вычисления факториала.

/* Определим метод, возвращающий int и в качестве аргумента принимающий другое целое число.*/

Console.WriteLine("Введите целое положительное число (n) не более 170.");

try /* Блок обработки исключений.*/
{
    int n = Convert.ToInt32(Console.ReadLine()); /* Метод вывода на экран вводимого пользователем
числа в формате int - это ключевое слово, которое используется для объявления переменной,
которая может хранить значение целого типа (целое число со знаком) в 
диапазоне от -2 147 483 648 до 2 147 483 647.*/

    if (n == 0) /* Если введённое число рано нулю, то...*/
        Console.WriteLine("Факториал 0 = 1");

    if (n < 0) /* Если введённое число меньше нуля, то...*/
        Console.WriteLine("Факториал отрицательного числа не существует.");

    double Factorial(int n) /* Когда мы будем вычислять большие числа,
то программа начнет выдавать отрицательные значения или нули. 
Это означает, что эти числа не вмещаются в тип данных интеджер (int). 
Чтобы это исключить, то нужно (int) поменять на (double), именно для возвращаемого результата.
Если в ответ выводятся, например, такие числа, как (1,2146304367025325E+205), то (Е+205) в нём,
означает, что это число нужно умножить на 10 в 205 степени.*/

    {
        if (n == 1) return 1;              /* Если введённое число равно единице, то должны вернуть 
                                          единицу потому что это определение факториала. 
                                          Факториал нуля, тоже, равен единице. 1!==1 и 0!==1.*/

        else return n * Factorial(n - 1);  /* Иначе нужно текущее значение умножить
                                          на факториал предыдущего значения числа.
                                          Обязательно вернуть значение (return).*/
    }
    int i = 0; //Вводим переменную(i)- это счётчик.

    for (i = 1; i <= n; i++) /* Начиная с единицы, до тех пор, пока счётчик не будет равен введённому числу,
                            будем вычислять факториал каждого числа (увеличивая (i), при каждой
                            итерации, на (1).*/
    {
        if (Factorial(i) > 1.7 * Math.Pow((10), 308))//Если факториал числа более 1.7*10 в степени 308, то...
        {
            Console.WriteLine(); /* Пустая строка для удобства чтения.*/
            Console.WriteLine($"Факториал числа {n} более 1,7х10 в степени 308");
            Console.WriteLine($"и стремится к бесконечности ▲");
            break; // Итерация прерывается           
        }
        Console.WriteLine($"Факториал {i!} = {Factorial(i)}"); /* В ответ выведтся значение каждого
                                                                  факториала от(1 до n!) включительно.*/
    }
}
catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Некорректный ввод данных. Введите целое число.");
}

