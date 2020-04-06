
//model created in first migration
using System.ComponentModel.DataAnnotations;

namespace ScriptMigration.Models
{
    public class FirstModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        //added in second migration
        [StringLength(50)]
        public string OtherField { get; set; }
    }
}
