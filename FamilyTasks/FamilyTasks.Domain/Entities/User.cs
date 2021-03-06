﻿using System;
using Microsoft.AspNetCore.Identity;

namespace FamilyTasks.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            base.Id = new Guid();
        }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}