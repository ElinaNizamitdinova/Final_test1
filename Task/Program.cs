string[] startArray = {"Hello", "paradox", "new", "-9", "Sunshine", "1", "++++"};
int rightLenght = 3;
System.Console.WriteLine("-----");


void PrintArray(string[] arr)
{   System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if(i<arr.Length-1){
            Console.Write(", ");
        }
        else{
            Console.Write("");
        }
    }
    System.Console.WriteLine("]");
}

// NewMatrix(startArray, rightLenght);