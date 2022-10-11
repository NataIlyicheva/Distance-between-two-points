void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ)
{
    double result = 0;
    double coordinateX = Math.Pow(secondX - firstX, 2);
    double coordinateY = Math.Pow(secondY - firstY, 2);
    double coordinateZ = Math.Pow(secondZ - firstZ, 2);

    result = Math.Sqrt(coordinateX + coordinateY + coordinateZ);

    Console.WriteLine($"Расстояние между координатами = {result}");
}

GetDistanceBetweenTwoPoints(7, 1, -5, -1, 0, 9);