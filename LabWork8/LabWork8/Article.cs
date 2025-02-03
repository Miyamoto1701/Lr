
public class Article
{
    public Article(string articleName, string autor, int yearOfPublication)
    {
        this.ArticleName = articleName;
        this.Autor = autor;
        this.YearOfPublication = yearOfPublication;
    }

    public string ArticleName { get; set; }
    public string Autor { get; set; }
    public int YearOfPublication { get; set; }

    public override string ToString()
    {
        return ($"articleName:{ArticleName}, autor:{Autor}, yearOfPublication:{YearOfPublication}");
    }


    public override bool Equals(object? obj)
    {
        Article article = obj as Article;
        return ArticleName == article.ArticleName && Autor == article.Autor && YearOfPublication == article.YearOfPublication;
    }
}

