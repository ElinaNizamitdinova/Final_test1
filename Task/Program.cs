


void NewMatrix(string[] arr, int size,int lengthNewArray)
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


int LengthOfNewArray(string[] arr,int size)
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


int rightLenght = 3;
Console.WriteLine("Введите длину первичного массива");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] startArray ={"Hello","sun","paradox","---","67"};
int newSize = LengthOfNewArray(startArray,rightLenght);
PrintArray(startArray);
Console.Write("-->");
NewMatrix(startArray, rightLenght,newSize);