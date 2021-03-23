using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsServices.Models
{
    [NotMapped]
    public class CreatedAccount
    {
        [Key]
        public string _id { get; set; }
        public string Email { get; set; }
    }
}
