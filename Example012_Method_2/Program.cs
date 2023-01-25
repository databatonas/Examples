﻿/* Вторая группа методов - которые ни чего не возвращают, 
но могут принимать какие-то аргументы*/

void Method2(string msg)/* void - ключевое слово, Method - идентификатор. В скобках аргументы*/
{
    Console.WriteLine(msg);/* msg - аргумент*/
}
/* Чтобы вызвать метод...*/
//Method2("Текст сообщения"); /*Если эту строку раскомментировать, то нужно будет */
                              /*закомментировать строку 13 и строку 30*/
/*Есть именованные аргументы- это когда мы явно хотим указать какому
  аргументу и какое значение мы хотим указать. Это нужно, если в методе несколько аргументов*/
//Method2(msg: "Текст сообщения"); /*Если эту строку раскомментировать, то нужно будет */
                              /*закомментировать строки 17 по 30*/

/*Для примера напишем метод 21*/
void Method21(string msg , int count)/* count- количество сообщений, которые будут выведены на экран*/
{
    
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4); /* Здесь 4 - это -count- сколько раз будет повторяться это сообщение.
/* Если раскомментировать эту строку, то нужно закомментировать строку 30*/

Method21(msg:"Текст",count: 4);/* Можно явно указать какому аргументу и какое значение мы хотим присвоить*/