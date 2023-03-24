// Игра в пирамидки.
/* wite- шпиль, который является рабочим, откуда мы будем брать текущий блинчик. 
on- шпиль, на котором пирамидка должна оказаться. some- промежуточный шпиль. 
count- количество блинов у нас всего есть (их можно задавать пользователю). Towers- любое название метода.*/
void Towers(string wite = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(wite, some, on, count - 1);
    Console.WriteLine($"{wite} >>{on}");
    if (count > 1) Towers(some, on, wite, count - 1);
}
Towers();