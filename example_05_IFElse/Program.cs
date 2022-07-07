Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "igor")
{
    Console.WriteLine("Super. Nice to meet you, Igor!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}