using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsDAL
{
    [NotMapped]
    public class PublishedAccount
    {
        [Key]
        public string _id { get; set; }
        public string Email { get; set; }
    }
}
