using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }

        public List<Permission> Permissions { get; set; }

        public List<Claim> Claims { get; set; }    


        public MockContext()
        {
            Roles = new List<Role>();
            Permissions = new List<Permission>();
            Claims = new List<Claim>();

            Roles.Add(new Role { Id = 01, Name = "admin", Description = "full access" });
            Roles.Add(new Role { Id = 02, Name = "student", Description = "lot access" });

            Permissions.Add(new Permission { Id = 03, Name = "ViewAllMarks", Description = " " });
            Permissions.Add(new Permission { Id = 04, Name = "ViewAllTimes", Description = " " });

            Claims.Add(new Claim { Id = 01, RoleId = 01, PormissioId = 03, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 02, RoleId = 02, PormissioId = 03, Policy = EPolicy.Deny });
   
    }
}
