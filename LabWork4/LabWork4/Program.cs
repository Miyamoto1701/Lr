int[] allcoins = { 4, 3, 1, };

GetCoins(allcoins, 6);

int[] searchedArray = { 1, 2, 7, 5, 8};

SearchLocalMax(searchedArray);

static void GetCoins(int[] allCoins, int value)
{
    string getedCoins = "";
    while (value != 0)
    {
        if (value >= allCoins[0])
        {
            value = value - allCoins[0];
            getedCoins += $"{allCoins[0].ToString()} ";
        }
        else if (value >= allCoins[1])
        {
            value = value - allCoins[1];
            getedCoins += $"{allCoins[1].ToString()} ";
        }
        else if (value >= allCoins[2])
        {
            value = value - allCoins[2];
            getedCoins += $"{allCoins[2].ToString()} ";
        }
        else if (value >= allCoins[3])
        {
            value = value - allCoins[3];
            getedCoins += $"{allCoins[3].ToString()} ";
        }
    }
    Console.WriteLine(getedCoins);
}

static void SearchLocalMax(int[] searchedarray)
{
    for (int i = 1; i < searchedarray.Length - 1; i++)
    {
        if (searchedarray[i - 1] < searchedarray[i] && searchedarray[i] > searchedarray[i + 1])
        {
            Console.WriteLine(searchedarray[i]);
            break;
        }
    }
}