using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAppModels
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        public virtual UserProfile UserInfo { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string  RelationPersonName { get; set; }

        public string Address { get; set; }
    }
}