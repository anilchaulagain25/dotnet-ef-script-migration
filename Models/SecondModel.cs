
//model created in first migration
using System.ComponentModel.DataAnnotations;

namespace ScriptMigration.Models
{
    //added in second migration
    public class SecondModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
