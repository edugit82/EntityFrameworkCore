using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Models
{
    [Table("Letra")]
    public class LetraModel
    {
        [Key]
        public long Id { get; set; }
        public char Letra { get; set; }
    }
}
