namespace Store;

public class Book
{
    public string Title { get; }
    public int Id { get; }

    public Book(int id, string title)
    {
        Id = id;
        Title = title;
    }
}
