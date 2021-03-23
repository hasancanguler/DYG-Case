using System;
using System.Collections.Generic;

namespace NewsDAL
{
    public class News
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Spot { get; set; }
        public DateTime PublishedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<NewsKeywords> NewsKeywords { get; set; }
        public MainCategory MainCategory { get; set; }
        public List<SourcesData> SourcesData { get; set; }
        public PublishedAccount PublishedAccount { get; set; }
        public CreatedAccount CreatedAccount { get; set; }
        public Story Story { get; set; }
        public string MainArtUrl { get; set; }

    }
}
