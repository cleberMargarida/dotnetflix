namespace dotnetflix.Models
{
    public class Tutorial
    {
        public int Id { get; set; }
        public string LinkVideo { get; set; }
        public string LinkThumbnailVideo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public double Duration { get; set; }
        public Categories Categorie { get; set; }
        public Author Author { get; set; }

    }
}
