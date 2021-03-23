using System;
using System.Collections.Generic;
using NewsServices;
using System.Text;

namespace NewsServices.Models
{
    public class NewsDto
    {
        public string Id { get; set; }
        private string title;
        public string Title
        {
            get { return title; }
            set { 
                title = value;
                url = FriendlyUrl.Slug(title);
            }
        }
        private string url;
        public string Url
        {
            get { return url; }
        }
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
