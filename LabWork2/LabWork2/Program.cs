int[] array = { 1, 2, 3, 4, 10 };
Array.Sort(array);
WriteArray(array);
Console.WriteLine(LineSearch(array, 1));
Console.WriteLine(BinarySearch(array, 423));
Console.WriteLine(JumpSearch(array, 15));

static int LineSearch(int[] array, int targetIndex)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == targetIndex)
            return i;
    return -1;
}

static int BinarySearch(int[] array, int targetIndex)
{
    int left = 0;
    int right = array.Length - 1;
    while (left <= right)
    {
        int MidElement = left + (right - left) / 2;
        if (array[MidElement] == targetIndex)
            return MidElement;
        if (array[MidElement] < targetIndex)
            left = MidElement + 1;
        else
            right = MidElement - 1;
    }
    return -1;
}

static int JumpSearch(int[] array, int targetIndex)
{
    int step = (int)Math.Sqrt(array.Length);
    int prevstep = 0;
    while (array[Math.Min(step, array.Length - 1)] < targetIndex)
    {
        prevstep = step;
        step += (int)Math.Sqrt(array.Length);
        if (prevstep >= array.Length) return -1;
    }
    while (array[prevstep] < targetIndex)
    {
        prevstep++;
        if (prevstep == Math.Min(step, array.Length)) 
            return -1;
    }
    if (array[prevstep] == targetIndex)
        return prevstep;
    return -1;

}

static void WriteArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}