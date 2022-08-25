int[] createArray()
{
    var random = new Random();

    var result = new int[10];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
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
    if (res < arr[i])
    {
    res = arr[i];
    }
}
var ar = arr;
var r = arr[0];
for (var i = 0; i < array.Length; i++)
{
    if (r > arr[i])
    {
    r = arr[i];
    }
}
int otvet = r + res;
Console.WriteLine();
Console. WriteLine(otvet);