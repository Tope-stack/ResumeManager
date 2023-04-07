using ResumeManagerAPI.Core.Entities.Enums;
using System.Text.Json.Serialization;

namespace ResumeManagerAPI.Core.Dtos
{
    public class CompanyDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        
        public CompanySize Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class GetCompanyDto
    {
        public string Name { get; set; }

        public CompanySize Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class CreateUpdateCompanyDto
    {
        public string Name { get; set; }     
        public CompanySize Size { get; set; }
    }

    public class CreateCompanyDto : CreateUpdateCompanyDto
    {

    }

    public class UpdateCompanyDto : CreateUpdateCompanyDto
    {

    }
}
