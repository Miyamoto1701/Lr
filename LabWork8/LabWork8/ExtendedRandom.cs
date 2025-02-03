
public class ExtendedRandom : Random
{
    public ExtendedRandom(int number) : base()
    {
        int[] ints = new int[number];
        for (int i = 0; i < number; i++)
            ints [i] = Next();
    }

}