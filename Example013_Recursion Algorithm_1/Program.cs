﻿// Заполнение двумерного массива.

string[,] table = new string[2, 5]; /* Здесь string- тип данных, [,]- указатель того, что будет две 
размерности. Одна размерность- это строки. Вторая размерность- столбцы. table- наименование массива.
new string- новый массив string. [2,5]- две строки, 5 столбцов*/

// String.Empty- Инициализация строк (по умолчанию пустые).
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

table[1, 2] = "слово";
/* Далее используем цикл в цикле, чтобы распечатать данный массив.*/
/* Так как строк две, то примем счётчик rows, который будет не больше 2.*/
/* Так как столбцов пять, то примем счётчик coloumns, который будет не больше 5.*/

for (int rows = 0; rows < 2; rows++)
{
    for (int coloumns = 0; coloumns < 5; coloumns++)
    {
        Console.WriteLine($"-{table[rows, coloumns]}-");/* Здесь (-)- это пустые строки.*/
    }
}
/* Всё правильно. Вывелось 10 элементов(из них девять пустых, а один элемент- (слово)).*/
