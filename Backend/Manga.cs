namespace Backend
{
    public class Manga
    {
        public string? MangaName { get; set; }
        public string? MangaLink {  get; set; }
        public string? MangaImg { get; set; }

        public Manga(string? mangaName, string? mangaLink, string? mangaImg)
        {
            MangaName = mangaName;
            MangaLink = mangaLink;
            MangaImg = mangaImg;
        }
    }
}
