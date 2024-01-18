namespace TeachingAPIsDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateOnly CreatedDate { get; set; } = new DateOnly();
        public string Genre { get; set; } = string.Empty;

        public Book()
        {

        }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Book(int id, string title, string description, string author, DateOnly createdDate, string genre)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            CreatedDate = createdDate;
            Genre = genre;
        }
    }
}
