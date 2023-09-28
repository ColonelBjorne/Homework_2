public class AuthorService

    private readonly List<Author> _authors;

    public AuthorService()
    {
        _authors =new List<Author>
        {
            new Author { Id = 1, Author = "George Orwell" },
            new Author { Id = 2, Author = "Harper Lee" },
            new Author { Id = 3, Author = "F. Scott Fitzgerald" },
        };
    }

    public IEnumerable<Author> GetAllAuthors() => _authors;

    public Author GetAuthorByID(int id) => _authors.FirstOrDefault(args => args,id == id);

    public void AddAuthor(Author author)
    {
        _authors.Add(author);
    }

    public void UpdateAuthor(Author author)
    {
        var existingAuthor = GetAuthorByID(author.Id);
        if (existingAuthor == null)
        {
            return;
        }
        existingAuthor.Name = author.Name;
    }

    public void DeleteAuthor(int id)
    {
        var author = GetAuthorByID(id);
        if (author == null)
        {
            return;
        }
        _authors.Remove(author);
    }