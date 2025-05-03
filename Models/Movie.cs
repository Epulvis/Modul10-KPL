namespace modul10_103022300057.Models
{
    public class Movie(string title, string director, List<string> stars, string description)
    {
        public string Title { get; set; } = title;
        public string Director { get; set; } = director;
        public List<string> Stars { get; set; } = stars;
        public string Description { get; set; } = description;
    }
}
