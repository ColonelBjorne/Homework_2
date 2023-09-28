public class AuthorService

    private readonly List<Author> _authors;

    public AuthorService()
    {
        _authors =new List<Author>
        {
            new Author { Id = 1, Author = "George Orwell" },
        }
    }