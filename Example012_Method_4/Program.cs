/* Четвёртая группа методов, которые что-то принимают и что-то возвращают.*/

string Method4(int count, string text)/* Выведем строку (text) count раз.*/
{
    int i = 0;
    string result = string.Empty;/* string.Empty- пустая строка (как ноль). 
                                    Вместо string.Empty можно ставить ("").*/

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;  /* result- это та переменная, значение которой мы хотим получить из метода.*/
}

/*Вызов метода...*/

/* Создадим переменную res.*/
string res = Method4(10, "какой-то текст "); /* На экране будет 10 раз "какой-то текст".*/
Console.WriteLine(res);