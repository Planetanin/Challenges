// length - размер строки, 
// размер массива arr - больше по условию задачи и достаточный чтобы не вывалиться за границы массива
public static char[] ReplaceSpaceBySpecialSymbols(char[] arr, int length)
{
    int spaceCount = 0;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] == ' ')
        {
            ++spaceCount;
        }
    }

    // т.к. заменяем 1 символ 3-мя, то понадобится еще N*2 символов (N - кол-во пробелов)
    int newLength = length + spaceCount * 2;

    for (int i = length - 1; i >= 0; --i)
    {
        if (arr[i] == ' ')
        {
            arr[newLength - 1] = '0';
            arr[newLength - 2] = '2';
            arr[newLength - 3] = '%';
            newLength -= 3;
        }
        else
        {
            arr[newLength - 1] = arr[i];
            newLength -= 1;
        }
    }
    return arr;
}