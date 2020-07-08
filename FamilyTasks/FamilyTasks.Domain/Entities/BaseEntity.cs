using System;

namespace FamilyTasks.Domain.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}