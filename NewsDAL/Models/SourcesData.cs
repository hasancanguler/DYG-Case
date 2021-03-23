using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsDAL
{
    [NotMapped]
    public class SourcesData
    {
        [Key]
        public string _id { get; set; }
        public string Title { get; set; }
    }
}

