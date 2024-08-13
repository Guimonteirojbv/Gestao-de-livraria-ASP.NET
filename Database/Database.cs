using Gestão_de_Livraria;




public class Database
{
    private static Database _instance;
    public static Database Instance => _instance ??= new Database();

    public Dictionary<int, Book> livros { get; private set; }

    private Database()
    {
        livros = new Dictionary<int, Book>();
;
    }

    public Book GetBook(int id)
    {
        return livros.ContainsKey(id) ? livros[id] : null;
    }

    public void CreateBook(Book book)
    {
        int key = new Random().Next(1, int.MaxValue);
        livros.Add(key, book);
        Console.WriteLine(livros);
    }

    public Dictionary<int, Book> GetAllBooks()
    {
        return livros;
    }

    public void DeleteBook(int id)
    {
        livros.Remove(id);
    }

    public void UpdateBook(int id, Book book)
    {
        var alReadyExistsBook = livros[id];

        alReadyExistsBook.Titulo = book.Titulo;
        alReadyExistsBook.Autor = book.Autor;
        alReadyExistsBook.Estoque = book.Estoque;
        alReadyExistsBook.Genero = book.Genero;
        alReadyExistsBook.Preco = book.Preco;

        livros.Remove(id);

        livros.Add(id, alReadyExistsBook);
    }
}

