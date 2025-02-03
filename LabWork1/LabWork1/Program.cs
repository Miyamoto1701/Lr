
int[] array = { 7, 0, -4, 3, 1, -2, 5 };



WriteArray(array);
BubleSort(array);
Console.WriteLine("Отсортированый массив: " + string.Join(",", array));

static void WriteArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

#region Selectionsort

static void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minElementIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minElementIndex])
            {
                minElementIndex = j;
            }
        }
        int temp = array[minElementIndex];
        array[minElementIndex] = array[i];
        array[i] = temp;
        WriteArray(array);
    }
}

#endregion
#region Bubble sort

static void BubleSort(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        bool swapped = false;
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }

        }
        WriteArray(array);
        if (!swapped)
        {
            break;
        }


    }
}



#endregion

#region InsertionSort
#endregion



