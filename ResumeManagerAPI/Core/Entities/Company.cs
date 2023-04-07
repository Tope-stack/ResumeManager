using ResumeManagerAPI.Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ResumeManagerAPI.Core.Entities
{
    public class Company : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public CompanySize Size { get; set; }

        // Relations
        public ICollection<Job> Jobs { get; set; }
    }
}
