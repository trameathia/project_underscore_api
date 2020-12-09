using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_underscore_api.Models
{
    public class Tag : BaseEntity
    {
        public int ID { get; set; }
        public int UserItemID { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<UserItem> UserItems { get; set; }
    }
}
