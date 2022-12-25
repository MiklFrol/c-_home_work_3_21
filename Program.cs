// Программа принимает координаты двух точек, и находит расстояние между ними в 3D пространстве.

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistanceFromCoordinate(int userX1, int userY1, int userZ1, int userX2, int userY2, int userZ2)
{
    double result = Math.Sqrt(Math.Pow((userX2 - userX1), 2) + (Math.Pow((userY2 - userY1), 2)) + (Math.Pow((userZ2 - userZ1), 2)));
    return result;
} 

int userX1 = getUserValue("Введите X первой звезды");
int userY1 = getUserValue("Введите Y первой звезды");
int userZ1 = getUserValue("Введите Z первой звезды");

int userX2 = getUserValue("Введите X второй звезды");
int userY2 = getUserValue("Введите Y второй звезды");
int userZ2 = getUserValue("Введите Z второй звезды");

double distance = getDistanceFromCoordinate(userX1, userY1, userZ1, userX2, userY2, userZ2);

Console.WriteLine($"Расстояние между данными звёздами: {distance} световых лет!");