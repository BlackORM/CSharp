// задача про двух друзей и собаку
Console.Write ("Введите скорость первого друга (м/с): ");
string fr1 = Console.ReadLine();
int friend1speed = Convert.ToInt32(fr1);
Console.Write ("Введите скорость второго друга (м/с): ");
string fr2 = Console.ReadLine();
int friend2speed = Convert.ToInt32(fr2);
Console.Write ("Введите скорость собаки (м/с): ");
string dog = Console.ReadLine();
int dogspeed = Convert.ToInt32(dog);
Console.Write ("Введите расстояние между друзьями (м): ");
string distin = Console.ReadLine();
Double dist = Convert.ToDouble(distin);
Console.Write ("Введите расстояние встречи (м): ");
string meetin = Console.ReadLine();
Double meet = Convert.ToDouble(meetin);
int count = 0, toWhom = 2;
Double time = 0;
while (dist > meet)
{
    if (toWhom == 1)
        {
        time = dist/(friend1speed + dogspeed);
        toWhom = 2;
        }
    else        
        {
        time = dist/(friend2speed + dogspeed);
        toWhom = 1;    
        }
        dist = dist - (friend1speed + friend2speed)*time;
        count = count + 1;
}    
Console.WriteLine(count);
