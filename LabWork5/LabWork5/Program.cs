public class Article
{
    private string _name;
    private string _author;
    private int _year;

    public Article()
    {
        _name = " ";
        _author = " ";
        _year = 0;
    }
    public Article(string name, string author, int year)
    {
        _name = name;
        _author = author;
        _year = year;
    }
    public string Name { get { return _name; } }
    public string Author { get { return _author; } }
    public int Year { get { return _year; } }

    public override string ToString()
    {
        return $"name:{_name},author:{_author},year{_year}";
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        Article article = new Article();
        Console.WriteLine(article.Name);

        Article article1 = new Article("name 1", "author 1", 2003);
        Article article2 = new Article("name 2", "author 2", 2007);
        Article article3 = new Article("name 3", "author 3", 2000);
        Article article4 = new Article("name 4", "author 4", 2004);

        List<Article> articles = new List<Article>()
        { article1, article2, article3, article4};


        string selectAuthor = "author 1";
        Console.WriteLine(selectAuthor);
        for (int i = 0; i < articles.Count; i++)
        {
            if (articles[i].Author == selectAuthor)
                Console.WriteLine(articles[i]);
        }

        int selectYear = 2006;
        Console.WriteLine(selectYear);
        for (int i = 0; i < articles.Count; i++)
        {
            if (articles[i].Year == selectYear)
                Console.WriteLine(articles[i]);
        }

    }
}