using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsServices.Models
{
    [NotMapped]
    public class Story
    {
        [Key]
        public string _id { get; set; }
        public List<Contents> Contents { get; set; }
    }
}
