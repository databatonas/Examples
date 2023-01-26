﻿/*Работа с текстом*/
//Задача
/*Дан текст. В тексте нужно все пробелы заменить чёрточками,
  маленькие буквы "к" заменить большими "К",
  а большие "С" заменить маленькими "с".*/

string text = "-Я думаю, - Сказал князь, улыбаясь, - что ежели бы "
              + "ваС послали вместо нашего милого Винценгероде "
              + "вы бы взяли приступом Согласие пруССкого короля. "
              + "Вы так красноречивы. "
              + "Вы дадите мне чаю?";

/*Пояснение*/
//                                             0 1 2 3 4
/*Если у нас будет какая-то строка string s = "g j k y f" , 
  то к определенному символу мы можем обратиться с помощью индекса*/
/*Например s[3] будет (y)*/

string Replace(string text, char oldValue, char newValue)/*Replace- произвольное название.
char- Этому типу соответствуют символьные литералы. oldValue- старое значение. 
newValue- новое значение.*/
{
    string result = string.Empty;/*Присвоим пустую строку*/

    int length = text.Length;/* Для того, чтобы получить длину нашей строки int length
                                нужно обратиться к свойству, 
                                показывающему количество символов в нашей строке.*/

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";/* Если текущий символ 
        text [i] совпал с тем символом, который мы хотим изменить oldValue, 
        то в резудьтат кладём новое значение в виде этой строки newValue.*/

        else result = result + $"{text[i]}";/* Иначе, если совпадений не обнаружено,
                                                то в result добавить текущий символ, который и был.*/
    }
    return result;
}

string newText = Replace(text, ' ', '|');/*Присвоим string text Replace(text, 
                                          и указываем что меняем пробелы "" на чёрточки |).
                                          При замене обязательно одинарные кавычки.*/

/* Чтобы заменить следующие символы, можно использовать, уже, наш newText.*/

newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);//Хотим увидеть значение newText*/