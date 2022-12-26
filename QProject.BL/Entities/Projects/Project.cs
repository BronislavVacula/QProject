using QProject.Base;
using QProject.Base.Enums;
using QProject.Base.Enums.Projects;
using QProject.BL.Entities.Administration;
using QProject.Shared.Attributes;

namespace QProject.BL.Entities.Projects
{
    [DatabaseTable(TableName = "projects", ViewName = "vProjects")]
    public class Project : EntityWithTS
    {
        #region Properties and fields
        public int? TemplateId { get; set; }
        public int? CustomerId { get; set; }
        public int? CategoryId { get; set; }

        public string Number { get; set; } = string.Empty;
        public int NumberInt { get; set; } = 0;
        public string? Name { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;

        public int? ResponsibleTeamId { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public int? ContactPersonId { get; set; }
        public string? MainContact { get; set; }

        public DateTime? ReceivedAt { get; set; }
        public DateTime? PlanStartAt { get; set; }
        public DateTime? RealStartAt { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? FinishedAt { get; set; }

        public decimal? PlanEarnings { get; set; } = 0;
        public decimal? PlanExpenses { get; set; } = 0;
        public decimal? CurrentEarnings { get; set; } = 0;
        public decimal? CurrentExpenses { get; set; } = 0;

        public long? PlanSpentTime { get; set; } = 0;
        public long? RealSpentTime { get; set; } = 0;

        public string Description { get; set; } = string.Empty;
        public int? CreatedById { get; set; }

        public ProjectState State { get; set; } = ProjectState.New;

        [DatabaseColumn(ReadOnly = true)]
        public string CategoryName { get; set; } = string.Empty;

        [DatabaseColumn(ReadOnly = true)]
        public string CustomerName { get; set; } = string.Empty;

        [DatabaseColumn(ReadOnly = true)]
        public decimal Finance => (CurrentEarnings ?? 0) - (CurrentExpenses ?? 0);

        /// <summary>
        /// Gets or sets the name of the responsible team.
        /// </summary>
        /// <value>
        /// The name of the responsible team.
        /// </value>
        [DatabaseColumn(ReadOnly = true)]
        public string? ResponsibleTeamName { get; set; }
        #endregion

        #region Related entities        
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [DatabaseColumn(ReadOnly = true)]
        public EnumerationItem? Category 
        {
            get => GetRelatedEntity<EnumerationItem>(CategoryId);
            set => SetRelatedEntity(value, CategoryId, new Dictionary<string, string>() 
            {
                { nameof(Id), nameof(CategoryId) }
            });
        }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        [DatabaseColumn(ReadOnly = true)]
        public Company? Company
        {
            get => GetRelatedEntity<Company>(CustomerId);
            set => SetRelatedEntity(value, CustomerId, new Dictionary<string, string>()
            {
                { nameof(Id), nameof(CustomerId) },
                { nameof(Company.Name), nameof(CustomerName) }
            });
        }
        #endregion
    }
}
