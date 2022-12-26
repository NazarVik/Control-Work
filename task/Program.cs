
string[] CreateStringArray()
{
    Console.Write("введите строки через пробел : ");
    string[] strArray = Console.ReadLine().Split(" ");
    return strArray; 
}

Console.Clear();
string[] array = CreateStringArray();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
        count++;
}

string[] newArray = new string[count];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

Console.WriteLine("[" + string.Join(", ", newArray) + "]");