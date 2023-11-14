﻿// Собрать строку с числами от a до b, a <= b

// Итеративный пoдход
string NumbersFor(int a, int b)
{
    string result = string.Empty; /* Переменной result присваиваем пустую строку.*/
    for (int i = a; i <= b; i++)  /* Запускаем цикл, который будет менять значение (i) 
                                     при а меньшем или равном b.*/
    {
        result += $"{i} ";       /* В результирующую строку собираем конкретное значение счётчика.*/ 
        
    }
    return result;               /* Возвращаем результат.*/
}

// То же самое, только с применением рекурсии.
string NumbersRec(int a, int b)
{
if(a < b) return $"{a} " + NumbersRec(a + 1,b); /* Если a меньше или равно b, то будем собирать 
строку с текущим значением (а) и вызывать новую копию метода со значениями аргументов 
(первый будет увеличен на единицу).*/

else return String.Empty; /* Иначе возвращаем пустую строку.*/
}
Console.WriteLine(NumbersFor(1, 10)); /* 1 2 3 4 5 6 7 8 9 10. В ответ вызовем метод с аргументами, 
                                                               вместо а и b (например: один и десять).*/
Console.WriteLine(NumbersRec(2,15));  // 1 2 3 4 5 6 7 8 9 10