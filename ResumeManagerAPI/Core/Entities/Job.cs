using ResumeManagerAPI.Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ResumeManagerAPI.Core.Entities
{
    public class Job : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public JobLevel Level { get; set; }

        // Relations 
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
