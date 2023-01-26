/* Четвёртая группа методов, которые что-то принимают и что-то возвращают.*/

/* Ранее мы использовали цикл while, а теперь будем использовать цикл for.*/

string Method4(int count, string text)/* Выведем строку (text) count раз.*/
{

    string result = string.Empty;/* string.Empty- пустая строка (как ноль). 
                                    Вместо string.Empty можно ставить ("").*/
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;  /* result- это та переменная, значение которой мы хотим получить из метода.*/
}

/*Вызов метода...*/

/* Создадим переменную res.*/
string res = Method4(10, "какой-то текст "); /* На экране будет 10 раз "какой-то текст".*/
Console.WriteLine(res);
