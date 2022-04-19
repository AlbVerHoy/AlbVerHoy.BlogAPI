using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.CosmosRepository;
using Newtonsoft.Json;

namespace AlbVerHoy.BlogAPI.Models
{
    public class Post : Item
    {

        [JsonProperty(PropertyName = "authorId")]
        [Required]
        public string AuthorId { get; set; }

        [JsonProperty(PropertyName = "title")]
        [Required]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "text")]
        [Required]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "creationDate")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [JsonProperty(PropertyName = "lastUpdatedDate")]
        [DataType(DataType.Date)]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
