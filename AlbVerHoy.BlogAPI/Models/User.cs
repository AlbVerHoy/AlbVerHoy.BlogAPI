using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.CosmosRepository;
using Newtonsoft.Json;

namespace AlbVerHoy.BlogAPI.Models
{
    public class User: Item
    {
        [JsonProperty(PropertyName = "email")]
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        [Required]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        [Required]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "dateOfBirth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
