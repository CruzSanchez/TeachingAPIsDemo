namespace TeachingAPIsDemo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Breed { get; set; }
        public List<int> Friends { get; set; }

        public Dog()
        {
            Friends = new List<int>();
        }

        public Dog(int id, string name, string owner, string breed, List<int> friends)
        {
            Id = id;
            Name = name;
            Owner = owner;
            Breed = breed;
            Friends = friends;
        }

        public Dog(int id, string name, string owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
            Friends = new List<int>();
        }
    }
}
