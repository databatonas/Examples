//Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)/* назначаем три числа и сравниваем их между собой.*/
{
int result = arg1; /* принимаем arg1 за максимальное число.*/
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result; /* возвращаем результат*/
}

int a1 = 21;
int b1 = 22;
int c1 = 23;
int a2 = 24;
int b2 = 25;
int c2 = 26;
int a3 = 27;
int b3 = 28;
int c3 = 29;

//int max1 = Max(a1,b1,c1); 
                        /* создал переменную max1 и сказал, 
                            что результатом работы функции Max 
                            будет являться максимальное из трех чисел: a1,b1,c1.*/
/* то же самое проделал со второй и третьей тройкой чисел*/
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
/* в финале сравнил max1, max2 и max3.*/
//int max = Max(max1, max2, max3); 

/* Можно сделать запись еще короче*/
/* можно внутри аргумента передать функцию*/
int max = Max(
    Max (a1,b1,c1),
    Max (a2,b2,c2),
    Max (a3,b3,c3));

Console.WriteLine(max);// результат.