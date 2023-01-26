Console.Write(" Введите имя пользователя: ");
string? username = Console.ReadLine();/*?- означает, что значение может быть и NALL.*/

if (username != null)/* Если username не равно nall? то...*/
{
    if (username.ToLower() == "маша")/*Перевод букв в верхний регистр. 
                                       Если имя "Маша" ввели любыми буквами 
                                       (на русском языке), то...*/
    {
        Console.WriteLine(" Ура, это же МАША! ");
    }
    else
    {
        Console.Write(" Привет, ");
        Console.WriteLine(username);
    }
}