using System;

namespace FamilyTasks.Domain.Entities
{
    public class User
    {
        public User()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}