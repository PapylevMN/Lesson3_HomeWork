// Программа расчета расстояния между точками в 3Д пространстве

double distanceCalc(double delta1, double delta2)
{
    return Math.Sqrt(Math.Pow(delta1,2) + Math.Pow((delta2),2));
}

int [] enterData()
{   int [] point = new int[3];
    Console.Write("x = ");
    point[0] = int.Parse(Console.ReadLine());
    Console.Write("y = ");
    point[1] = int.Parse(Console.ReadLine());
    Console.Write("z = ");
    point[2] = int.Parse(Console.ReadLine());
    return point;
}
int [] pointOne = new int[3];
int [] pointTwo = new int[3];
Console.WriteLine("Введите координаты первой точки:");
pointOne = enterData();
Console.WriteLine("Введите координаты второй точки:");
pointTwo = enterData();

double deltaX = pointOne[0]  - pointTwo[0];
double deltaZ = pointOne[2] - pointTwo[2];
double deltaY = pointOne[1] - pointTwo[1];
Console.WriteLine($"Расстояние между точками = {Math.Round(distanceCalc(deltaY, distanceCalc(deltaX, deltaZ)), 2)}");

