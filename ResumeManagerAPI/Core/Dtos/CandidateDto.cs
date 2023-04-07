using ResumeManagerAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ResumeManagerAPI.Core.Dtos
{
    public class CandidateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }
        public long JobId { get; set; }
        public Job Job { get; set; }
    }

    public class GetCandidateDto : CandidateDto
    {
        public string JobTitle { get; set; }
    }

    public class CreateUpdateCandidateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }
        public long JobId { get; set; }
    }

    public class CreateCandidateDto : CreateUpdateCandidateDto
    {

    }

    public class UpdateCandidateDto : CreateUpdateCandidateDto
    {

    }
}
