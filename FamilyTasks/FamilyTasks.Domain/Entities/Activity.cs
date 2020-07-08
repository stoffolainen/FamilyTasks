using System;

namespace FamilyTasks.Domain.Entities
{
    public class Activity : BaseEntity
    {
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public string Notes { get; set; }
        
        public User User { get; set; }
        public Chore Chore { get; set; }
    }
}