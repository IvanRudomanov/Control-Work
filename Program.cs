using System;

string[] Char_Arr_Set(int numb_el)
{
    string[] str_arr = new string[numb_el];
    int[] numb_arr = new int[numb_el];
    for (int i = 0; i <= numb_arr.Length-1; i++)
    {
        numb_arr[i] = new Random().Next(1, 9); 
    }
    for (int i = 0; i <= numb_el-1; i++)
    {
        for (int j = 1; j <= numb_arr[i]; j++)
        {
            str_arr[i] = str_arr[i] + Convert.ToChar(new Random().Next(64,122));
        }
        Console.Write("["+str_arr[i]+"] ");
    }
    return(str_arr);
}

Console.WriteLine("Введите m значение: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] str_arr = Char_Arr_Set(m);
string[] str_rez = new string[m];
int j = 0;
Console.WriteLine();
for (int i = 0; i <= m-1; i++)
{
    if (str_arr[i].Length < 4)
    {
        str_rez[j] = str_arr[i];
        Console.Write("["+str_rez[j]+"] ");
        j++;
    }
}
