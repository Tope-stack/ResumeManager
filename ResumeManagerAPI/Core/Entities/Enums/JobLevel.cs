namespace ResumeManagerAPI.Core.Entities.Enums
{
    public enum JobLevel
    {
        Intern,
        Junior,
        [System.Runtime.Serialization.EnumMember(Value = "Mid-Level")]
        Mid_Level,
        TeamLead,
        Cto,
        Architect
    }
}
