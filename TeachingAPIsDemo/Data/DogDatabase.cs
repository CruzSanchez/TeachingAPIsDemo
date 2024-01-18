using System.Text.Json;
using TeachingAPIsDemo.Models;

namespace TeachingAPIsDemo.Data
{
    public class DogDatabase
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        public static void BringForthTheDogs()
        {
            var jsonData = File.ReadAllText("Data/Dogs.json");

            Dogs = JsonSerializer.Deserialize<List<Dog>>(jsonData, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            }) ?? new List<Dog>();
        }
    }
}