using System;
using System.Collections.Generic;

namespace DataReader.DataAccess.Models;

public partial class Project
{
    public Guid ProjectSk { get; set; }

    public Guid? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? AnalyticsUpdatedDate { get; set; }

    public string? ProjectVisibility { get; set; }

    public virtual ICollection<WorkItem> WorkItems { get; set; } = new List<WorkItem>();
}
