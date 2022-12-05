using QProject.Base;
using Shared.Attributes;

namespace QProject.BL.Entities.Projects
{
    [DatabaseTable(TableName = "projects")]
    public class Project : Entity
    {
        public string? Number { get; set; }
        public string? Name { get; set; }
    }
}
