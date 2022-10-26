﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/**
* Defines properties for a user that will be stored in database
* Used by Entity Framework Core
*/

namespace CitationWebAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public string username { get; set; } = String.Empty;
        public string password { get; set; } = String.Empty;
        public string email { get; set; } = String.Empty;
        public string officer_badge { get; set; } = String.Empty;
        public string officer_name { get; set; } = String.Empty;
    }
}
