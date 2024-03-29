﻿/* Обход структур. Знакомство с языками программирования (лекции). Урок 7. 
   Дополнительная лекция. Рекурсия: продолжение.(32 минута).*/
/* Распишем дерево примера ((4 - 2) * (1 + 3)) / 10 */

string emp = String.Empty; /* Пустая строка.*/
/* Имеется одномерный массив, представляющий данное дерево.*/
/* (emp) используется для того, чтобы вся строчка вмещалась без горизонтального скрола.*/
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11   
void InOrderTraversal(int pos = 1) /* Описываем метод, позволяющий делать обход. 
В качестве аргумента указываем ту позицию, с которой будем начинать данный обход и...*/
{
    if (pos < tree.Length) /* делаем проверку. Если наша позиция вылетела за количество элементов, 
    которые в нашем дереве хранятся, то на этом наша рекурсия закончена.*/
    {
        int left = 2 * pos; /* Считаем позицию левого поддерева.*/
        int right = 2 * pos + 1; /* Считаем позицию правого поддерева.*/

        /* Далее, делаем проверку: если левое поддерево имеется (left < tree.Length) (т.е. не вылетаем за 
        границы нашего дерева) и тот элемент, который там хранится не является пустым 
        (!String.IsNullOrEmpty(tree[left]), (например позиции 6 и 7 элементов), то в этом случае нужно 
        рекурсивно запустить обход того дерева с текущей позицией.*/
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);

        Console.Write(tree[pos]); /* Выводим значение числа, либо операции 
        ({emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}).*/

        /* То же самое, что и с левым поддеревом делаем с правым.*/
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal(); /* Вызов метода.*/