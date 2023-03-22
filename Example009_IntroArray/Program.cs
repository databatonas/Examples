//Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)/* назначаем три числа и сравниваем их между собой.*/
{
int result = arg1; /* принимаем arg1 за максимальное число.*/
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result; /* возвращаем результат.*/
}
// индексы      0  1  2  3  4  5  6  7  8
int [] array = {21,22,23,24,25,26,27,28,29};


int max = Max(
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8])
);
Console.WriteLine(max);// результат.
