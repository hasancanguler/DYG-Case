using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewsServices.Models
{
    [Keyless]
    [NotMapped]
    public class NewsKeywords
    {
        public string Keyword { get; set; }
    }
}
