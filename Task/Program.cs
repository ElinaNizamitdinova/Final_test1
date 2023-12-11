


void NewMatrix(string[] arr, int size, int lengthNewArray)
{
    string[] newArray = new string[lengthNewArray];
    int indexNewArray = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= size)
        {
            newArray[indexNewArray] = element;
            indexNewArray++;

        }

    }

    PrintArray(newArray);
}


int LengthOfNewMatrix(string[] arr, int size)
{
    int lenghtNew = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= size)
        {
            lenghtNew++;

        }

    }
    return lenghtNew;
}

void PrintArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write("");
        }
    }
    System.Console.Write("]");
}
string[] GetArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
        Console.WriteLine(array[i]);

    }

    return array;
}

int rightLenght = 3;
Console.WriteLine("Введите длину первоначального массива");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] startArray = GetArray(sizeArr);
int newSize = LengthOfNewMatrix(startArray, rightLenght);
PrintArray(startArray);
Console.Write("-->");
NewMatrix(startArray, rightLenght, newSize);