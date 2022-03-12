using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<Student> Students { get; set; }
        IList<SubjectGroup> SubjectGroups { get; set; }
    }
}