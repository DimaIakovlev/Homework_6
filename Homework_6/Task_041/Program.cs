// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.Write($"Для чисел [{String.Join(", ", baseArray)}] количество положительных чисел: ");
Console.WriteLine(GetPositiveNum(baseArray));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int GetPositiveNum(int[] array)
{
    int res = 0;
    foreach (int item in array)
    {
        if (item > 0) res++;
    }
    return res;
}