using static System.Console;
using static System.Convert;
using static System.Math;


int t;
string[] str1 = new string[35];

t = ToInt32(ReadLine());
for (int i = 0; i < t; i++)
{
    string str2 = ReadLine();
    char ch = str2[str2.Length - 1];
    switch (ch)
    {
        case 'o':
            str1[i] = "FILIPINO";
            break;
        case 'u':
            str1[i] = "JAPANESE";
            break;
        case 'a':
            str1[i] = "KOREAN";
            break;
    }
}
for (int i = 0; i < t; i++)
{
    WriteLine(str1[i]);
}