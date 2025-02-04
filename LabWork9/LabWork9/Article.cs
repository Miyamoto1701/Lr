public class Article : IPrinter
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

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
}
