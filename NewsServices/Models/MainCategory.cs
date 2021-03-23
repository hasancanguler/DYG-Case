using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsServices.Models
{
    [Keyless]
    [NotMapped]
    public class MainCategory
    {
        public string Title { get; set; }
        public string Slug { get; set; }
    }
}

