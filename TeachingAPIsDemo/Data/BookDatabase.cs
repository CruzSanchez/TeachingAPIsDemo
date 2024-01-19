using System.Text.Json;
using TeachingAPIsDemo.Models;

namespace TeachingAPIsDemo.Data
{
    public class BookDatabase
    {
        public static List<Book> Books { get; set; } = new List<Book>();

        public static void BringForthTheBooks()
        {
            var jsonData = File.ReadAllText("Data/Books.json");

            Books = JsonSerializer.Deserialize<List<Book>>(jsonData, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            }) ?? new List<Book>();
        }

        public static void ResetData()
        {
            var jsonData = File.ReadAllText("Data/Backups/Books.json");

            File.WriteAllText("Data/Books.json", jsonData);

            BringForthTheBooks();
        }
    }
}
