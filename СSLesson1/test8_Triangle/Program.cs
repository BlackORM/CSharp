// Ставим точки в середине отрезка
Console.Clear();
Console.Write ("Введите количество точек: ");
string num = Console.ReadLine();
int numdots = Convert.ToInt32(num);
int xa = 20, ya = 1, xb = 1, yb = 20, xc = 40, yc = 20;
Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");
int x = xa, y = ya, count=0;
while (count < numdots)
{
    int newdot = new Random().Next(0, 3);
    if (newdot == 0)
        {
            x=(x + xa) / 2;
            y=(y + ya) / 2;
        }   
    if (newdot == 1)
        {
            x=(x + xb) / 2;
            y=(y + yb) / 2;
        }  
    if (newdot == 2)
        {
            x=(x + xc) / 2;
            y=(y + yc) / 2;
        } 
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");                     
    count = count + 1;   
}