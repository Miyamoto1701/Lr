interface IPrinter
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public void Print()
    {
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Имя автора: {author}");
        Console.WriteLine($"Год публикации {year}");
    }
}