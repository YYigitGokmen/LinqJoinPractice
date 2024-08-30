using LinqJoınPractice;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        // Her iki tabloya da örnek veriler ekleyin.En az 3 yazar ve 4 kitap ekleyin.
        List<Author> author = new List<Author>();

        author.Add(new Author { AuthorId =1, name ="Orhan Pamuk" });
        author.Add(new Author { AuthorId =2, name ="Elif Şafak" });
        author.Add(new Author { AuthorId =3, name ="Ahmet Ümit" });

        List<Book> book = new List<Book>();

        book.Add(new Book { bookId = 1, title = "Kar", AuthorId = 1 });
        book.Add(new Book { bookId = 2, title = "Istanbul", AuthorId = 1 });
        book.Add(new Book { bookId = 3, title = "10 minutes 38 seconds in this strange world", AuthorId = 2 });
        book.Add(new Book { bookId = 4, title = "Beyoğlu Rapsodisi", AuthorId = 3 });

        //Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun.
        //Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.

        var authorBookJoin = author.Join(
            book,
            author => author.AuthorId,
            book => book.AuthorId,
            (author, book) => new
            {
                AuthorName = author.name,
                BookTitle = book.title,
            });

        //Oluşturduğunuz LINQ sorgusunun sonucunu ekrana yazdırın.
        //Her kitabın başlığı ve yazarının adını içeren bilgileri göstermelisiniz.

        Console.WriteLine("Joined Authors and Books:");
        foreach (var item in authorBookJoin)
        {
            Console.WriteLine($"Author: {item.AuthorName}, Book: {item.BookTitle}");
        }

    }
}