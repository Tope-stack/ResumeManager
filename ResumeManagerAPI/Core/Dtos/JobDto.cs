using ResumeManagerAPI.Core.Entities.Enums;

namespace ResumeManagerAPI.Core.Dtos
{
    public class JobDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class GetJobDto
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class CreateUpdateJobDto
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }

    public class CreateJobDto : CreateUpdateJobDto
    {

    }

    public class UpdateJobDto : CreateUpdateJobDto
    {

    }
}
