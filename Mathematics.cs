class Mathematics
{
    public static int IncreaseByOne(int x)
    {
        return x + 1;
    }

    public static void IncreaseByOneRef(ref int x)
    {
        x += 1;
    }

    public static void DivideByTwo(int x, out int quotient, out int remainder)
    {
        quotient = x / 2;
        remainder = x % 2;
    }

}