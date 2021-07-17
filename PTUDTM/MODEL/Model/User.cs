using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Model
{
    public partial class User
    {

        [JsonProperty("username")]
        public string Username { get;set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("usergroup")]
        public string Usergroup { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("point")]
        public int Point { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        public User(string username, string email, string name, string gender, string usergroup, DateTime birthday, string avatar, int point, DateTime createdAt, DateTime updatedAt)
        {
            Username = username;
            Email = email;
            Name = name;
            Gender = gender;
            Usergroup = usergroup;
            Birthday = birthday;
            Avatar = avatar;
            Point = point;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
