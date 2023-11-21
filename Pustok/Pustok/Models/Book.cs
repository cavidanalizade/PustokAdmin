namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<BookImage>BookImages { get; set; }


    }
}
