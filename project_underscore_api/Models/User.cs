﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace project_underscore_api.Models
{
    public class User : BaseEntity
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        public List<UserItem> Items { get; set; } = new List<UserItem>();
    }
}
