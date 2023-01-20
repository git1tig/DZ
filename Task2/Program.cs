// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23

double Dist3D(int ax, int ay , int az, int bx, int by, int bz)
{
    return Math.Sqrt((Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)));
}


int[] x = new int[2];
int[] y = new int[2];
int[] z = new int[2];
string[] DotName = new string[] { "A", "B" };
int i = 0;
while (i <= 1)
{
    Console.Write("Введите координату x для точки " + DotName[i] + ":");
    while (!Int32.TryParse(Console.ReadLine(), out x[i]))
    {
        Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    }

    Console.Write("Введите координату y для точки " + DotName[i] + ":");
    while (!Int32.TryParse(Console.ReadLine(), out y[i]))
    {
        Console.WriteLine("Ввод  неверный. Пожалуйста, введите корректное число");
    }
    Console.Write("Введите координату z для точки " + DotName[i] + ":");
    while (!Int32.TryParse(Console.ReadLine(), out z[i]))
    {
        Console.WriteLine("Ввод  неверный. Пожалуйста, введите корректное число");
    }
    i++;
}
Console.WriteLine("Расстояние между точками равно:" + Dist3D(x[0],y[0],z[0],x[1],y[1],z[1]).ToString("#.##"));
