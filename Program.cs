// See https://aka.ms/new-console-template for more information


// string[] InputArr()
// {
//     Console.WriteLine("Bведите кол-во строк в массиве: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     string[] str = new string[n];
//     Console.WriteLine("Введите строки");
//     int i = 0;
//     while (i != n)
//     {
//         str[i] = Console.ReadLine();
//         i++;
//     }
//     return str;
// };
// ShowArray(InputArr());





//  "Hello", "2", "world", ":-)"

// "Russia", "Denmark", "Kazan", "123", "1234" 

string[] Array1 = { "Hello", "2", "world", ":-)" };

int size = Array1.Length; //размер не больше первоначального...
string[] Array2 = new string[size];
void ShowArray(string[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
};
ShowArray(Array1);



int j = 0;
for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i].Length < 4)
    {
        Array2[j] = Array1[i];
        j++;
    }
}
Console.WriteLine(Array2.Length);
ShowArray(Array2);

