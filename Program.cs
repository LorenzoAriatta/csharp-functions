// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Functions

void StampaArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("elemento" + " " + array[i]);
    }
}


int Quadrato(int number)
{
    int square = number * number;

    //Console.WriteLine($"The square of {number} is: {square}");

    return square;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] squareArray = new int[array.Length];

    for(var i = 0; i < array.Length; i++)
    {
        squareArray[i] = Quadrato(array[i]);
    }

    return squareArray;
}


int SommaElementiArray(int[] array)
{
    int sum = 0;

    for( var i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    Console.WriteLine($"The sum of all elements are: {sum}");

    return sum;
}


//int[] numbers = { 2, 6, 7, 5, 3, 9 };
//int[] arrayToSquare = ElevaArrayAlQuadrato(numbers);

Console.Write("Create your array. How many elements do you want? ");
int userInput = Int32.Parse(Console.ReadLine());
int[] userArray = new int[userInput];



for (var i = 0; i < userArray.Length; i++)
{
    int userNumber = Int32.Parse(Console.ReadLine());
    userArray[i] = userNumber;
}

int[] arrayToSquare = ElevaArrayAlQuadrato(userArray);


Console.WriteLine("First function: print the elements ");
StampaArray(userArray);
Console.WriteLine("-----");

Console.WriteLine("Second function: print the square for each element in array ");
StampaArray(arrayToSquare);
Console.WriteLine("-----");

Console.WriteLine("Third function: print the sum of all elements in array ");
SommaElementiArray(userArray);
Console.WriteLine("-----");

Console.WriteLine("Fourth function: print the sum of all square elements ");
SommaElementiArray(arrayToSquare);
Console.WriteLine("-----");

