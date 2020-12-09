using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_underscore_api.Models
{
    public class UserItem : BaseEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        public Uri Url { get; set; }
        public string ImageLocation { get; set; }
        public string Description { get; set; }
        public string Opinion { get; set; }
        [Required]
        public int Rating { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
