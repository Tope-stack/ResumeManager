using System.ComponentModel.DataAnnotations;

namespace ResumeManagerAPI.Core.Entities
{
    public class Candidate : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string CoverLetter { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string ResumeUrl { get; set; }


        // Relations
        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}
