﻿/* Задача. Дан массив {17,5,4,38,2,6,7,1,1, 157, 15478, 0}. Упорядочить массив с 
   максимального до минимального значений элементов.*/

//Решение.
/* 1. Найти позицию максимального элемента в несортированной части массива.*/
/* 2. Произвести обмен этого элемента с элементом первой несортированной позиции.*/
/* 3. Повторять, пока есть несортированные элементы.*/

/* 1. Введём массив.*/

int[] arr = { 17, 5, 4, 38, 2, 6, 7, 1, 1, 157, 15478, 54, 0 };

/* 2. Выведем массив на экран с помощью этого метода.*/
void PrintArray(int[] array)

{
    int count = array.Length;/* Получение количества элементов.*/

    for (int i = 0; i < count; i++)/* Пробегаем по всем элементам массива.*/
    {
        Console.Write($"{array[i]} ");/* Каждый элемент массива будет 
                                         выводиться на экран через пробел, потому,
                                         что после фигурных скобок пробел.*/
    }
    Console.WriteLine();/* Пустая строка для отделения следующего 
                           ответа ( сортированного массива).*/
}

/*3. Метод, который упорядочит наш массив.*/

void SelectionSort(int[] array)/* В качестве аргумента будет приходить
                                  некоторый массив array.*/
{

    for (int i = 0; i < array.Length - 1; i++)/* Если мы начинаем поиск минимального от i+1 (ниже),
                                                 где i меняется до максимального значения нашего
                                                 массива, то искусственно вычитаем 1 из длинны 
                                                 массива и тогда получится, что i+1 даст общее
                                                 количество элементов*/
    {
        int maxPosition = i;/* Определяем позицию элемента, для которого, в 
                               дальнейшем, будем производить следующие действия.*/

        for (int j = i + 1; j < array.Length; j++)/* То, что не сортировано начинается с i+1 позиции 
                                                     и идём до последнего элемента массива.*/
        {
            if (array[j] > array[maxPosition]) maxPosition = j;/* Ищем минимальный элемент. 
                                                                  Если текущий элемент меньше того 
                                                                  элемента, который мы предполагали
                                                                  на позиции minPosition, то эту 
                                                                  позицию нужно сохранить.*/
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);/*arr- Наименование нашего метода. Он выводит на экран несортированный массив.*/
SelectionSort(arr);/* Вызываем метод упорядочивания массива, он всё считает и...*/
PrintArray(arr);   /* Выводит на экран сортированный массив,
                      потому, что, перед выводом, мы применили метод SelectionSort.*/
