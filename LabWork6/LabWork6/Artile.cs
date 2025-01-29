public class Article
{
    private string title;
    private string author;
    private int year;

    public Article()
    {
        title = "без названия";
        author = "без автора";
        year = 0;
    }

    public Article(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Имя автора: {author}");
        Console.WriteLine($"Год публикации {year}");
    }
}