using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    public partial class Book
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("uploader")]
        public string Uploader { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("poster")]
        public string Poster { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("view")]
        public int View { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("like")]
        public int Like { get; set; }

        public Book()
        {
            this.Id = "";
            this.Title = "";
            this.Author = "";
            this.Uploader = "";
            this.Category = "";
            this.Poster = "";
            this.Description = "";
            this.View = 0;
            this.CreatedAt = new DateTime();
            this.UpdatedAt = new DateTime();
            this.Like = 0;
        }

        public Book(string id, string title, string author, string uploader, string category, string poster, string description, int view, DateTime createdAt, DateTime updatedAt, int like)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Uploader = uploader;
            this.Category = category;
            this.Poster = poster;
            this.Description = description;
            this.View = view;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Like = like;
        }

    }
}
