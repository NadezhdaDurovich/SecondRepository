// Особое приветствие для избранного пользователя
Console.Write("Введите Ваше Имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Урра! Это же МАША!");

}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}