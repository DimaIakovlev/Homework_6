/*  Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
    */


Console.Clear();
Console.Write("\nВведите значения b1 и k1 для первого уровнения через пробел: ");
string elements1 = Console.ReadLine();
Console.Write("\nВведите значения b2 и k2 для второго уровнения через пробел: ");
string elements2 = Console.ReadLine();
double[] baseArray1 = GetArrayFromString(elements1);
double[] baseArray2 = GetArrayFromString(elements2);

GetIntersectionPoint(baseArray1, baseArray2);

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;

}
void GetIntersectionPoint(double[] array1, double[] array2)
{
    double x = (array2[0] - array1[0]) / (array1[1] - array2[1]);
    double y = (array2[1] * x + array2[0]);
    Console.Write($"\nКоординаты точки пересечения прямых: [{x},{y}]");
}
