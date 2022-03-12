using System;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
    public class Role: IdentityRole<int>
    {
        RoleValue RoleValue { get; set; }

        Role()
        {

        }

        Role(string name, RoleValue roleValue)
        {
            this.Name = name;
            this.RoleValue = roleValue;
        }
    }
}