string[] names = { "hello", "2", "world", ":-)" };

string[] ArrayLessThree(string[] words)
{
    int count = 0;
    string[] temp = new string[words.Length];
    for (int i = 0; i < words.Length; i++)
        if (words[i].Length <= 3)
        {
            temp[count] = words[i];
            count++;
        }
    Array.Resize(ref temp, count);
    return temp;
}

void ShowArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
        Console.Write(str[i] + ", ");
}

ShowArray(ArrayLessThree(names));
