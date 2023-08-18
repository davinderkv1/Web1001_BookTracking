public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
    public string Author { get; set; }

    public Category Category { get; set; }
}
