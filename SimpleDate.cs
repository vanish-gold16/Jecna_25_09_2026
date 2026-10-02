struct SimpleDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public SimpleDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }

    public bool IsLeapYear()
    {
        return Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0);
    }

    public static void CreateNewDate(ref SimpleDate d, int day, int month, int year)
    {
        d = new SimpleDate(day, month, year);
    }

}