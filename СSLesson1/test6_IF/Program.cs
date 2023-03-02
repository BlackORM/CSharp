// Ввод имени, выделение знакомых имен
Console.Write ("Введите имя: ");
string user = Console.ReadLine();

if (user.ToLower() == "андрей")
{
Console.WriteLine("Привет, Андрюха! Сколько лет сколько зим!))");
}
else
{
Console.Write("Hello, ");
Console.Write(user);
Console.WriteLine("!");    
}