﻿/* Создаем массив (он сейчас на 32 строке) и сверху пишем методы. */
// Метод 1
void FillArray (int [] collection) /*void-оператор, который ни чего не возвращает и значит, 
                                     что с ним не нужно использовать оператор return, 
                                     который делает возврат. FillArray-наименование метода 
                                     (перевод-заполняющий массив). collection- аргумент (любое слово). */
{
    int length = collection.Length; /* length-длина массива. */
    int index = 0;
    while(index < length)
    {
        collection [index] = new Random().Next(1,10); /* В левойчасти обращение к аргументу с индексом, 
                                                         а в правой новое целое случайное число из диапозона 
                                                         от 1 до 10. */
        index++;                                                 
    }
}

// Метод 2-печать массива на экран.
void PrintArray(int[] col) /* PrintArray-печать массива. col- это какая-то другая переменная. */
{
    int count = col.Length; /* количество элементов. */
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]); /* выводим на экран значение текущего элемента. */
        position++;
    }
}
// Тестирование наших методов.

/* Теперь можно найти позицию нужного элемента в массиве с 
использованием нашего метода. 
Для этого нам нужно описать метод отличный от void. 
В данном случае он будет возвращать позицию, т.е. index. 
Назовем этот метод IndexOf с аргументом collection и какой-то элемент find . */
int IndexOf(int[] collection, int find)
{
    int count = collection.Length; //Определяет количество элементов.
    int index = 0;
    int position = -1;             /*Если мы введем число, которое, точно, не встречается в 
                                     нашем массиве, например 197, то dotnet run нам выдаст ноль. 
                                     Для этого можно возвращать -1 или -2, не важно. */
    while (index < count)
    {
        if(collection[index] == find)// если collection совпал с find, то
        {
          position = index;
          break;                      /*чтобы программа искала только первую нужную нам цмфру,
                                       (если их несколько одинаковых) */
        }
        index++;
    }   
    return position;
}


int [] array = new int [10];/*Создаем массив и укажем, что в нем, пусть будет, 10 элементов. 
                              Строку опустим вниз, а сверху будем создавать наш метод. */

FillArray(array);           /*вызываем этот метод с наименованием. */
array[5] = 4;               /*искуственно добавим четверку на пятую позицию. для того, 
                              чтобы в массиве было несколько четверок.*/
array[6] = 4;               /*искуственно добавим четверку на шестую позицию. для того, 
                              чтобы в массиве было несколько четверок.*/                             
PrintArray(array);          /*это метод вывода на печать. */

//Теперь можно потестировать
int pos = IndexOf(array, 4);          /* определим переменную pos и положим в нее результат работы IndexOf. 
                               В качестве аргумента будет передаваться наш массив и, 
                               например, будем искать четверку */
Console.WriteLine();         /* Пустая строка, чтобы отделить вывод массива от вывода индекса четверки */               
Console.WriteLine(pos);                              
