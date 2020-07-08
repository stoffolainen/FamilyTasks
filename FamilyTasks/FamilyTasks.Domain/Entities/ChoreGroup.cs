using System;
using System.Collections.Generic;

namespace FamilyTasks.Domain.Entities
{
    public class ChoreGroup : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}