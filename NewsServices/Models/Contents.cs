using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NewsServices.Models
{
    
    public class Contents
    {
        [Key]
        public string _id { get; set; }
        public string _t { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
    }
}
