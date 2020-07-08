using System;

namespace FamilyTasks.Domain.Entities
{
    public class Chore : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ChoreGroup ChoreGroup { get; set; }
    }
}