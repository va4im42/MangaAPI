using System.Collections.Generic;

namespace Backend
{
    public class MangaSuggestion
    {
        public string Value { get; set; }
        public string Link { get; set; }
        public List<string> Names { get; set; }
        public string Additional { get; set; }
        public string Thumbnail { get; set; }
    }

    public class MangaResponse
    {
        public string Query { get; set; }
        public List<MangaSuggestion> Suggestions { get; set; }
    }
}
