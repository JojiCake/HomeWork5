int[] createArray()
{
    var random = new Random();

    var result = new int[10];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 5);
    }
    return result;
}

var array = createArray();
for (var i = 0; i < array.Length; i++)
    Console.Write(array[i] + ", ");

var arr = array;
var res = 0;
for (var i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        res = res + 0;
    }
    else
    {
        res = res + arr[i];

    }
}
Console.WriteLine();
Console.WriteLine(res);