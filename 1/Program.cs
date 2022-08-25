int[] createArray()
{
    var random = new Random();

    var result = new int[10];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}

var array = createArray();
for (var i = 0; i < array.Length; i++)
    Console.Write(array[i] + ", ");

var arr = array;
int r = 0;
for (var i = 0; i < arr.Length; i++)
{
        if (arr[i] % 2 == 0)
        {
            r++;
        }
}
Console.WriteLine();
Console.WriteLine(r);
