//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeyPhase.Chat.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.ProjectHistories = new HashSet<ProjectHistory>();
            this.TaskHistories = new HashSet<TaskHistory>();
            this.Teams = new HashSet<Team>();
            this.Phases = new HashSet<Phase>();
            this.Phases1 = new HashSet<Phase>();
            this.Teams1 = new HashSet<Team>();
            this.Projects = new HashSet<Project>();
            this.Tasks = new HashSet<Task>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string Password { get; set; }
        public string BgColour { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<ProjectHistory> ProjectHistories { get; set; }
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }
        public virtual ICollection<Phase> Phases1 { get; set; }
        public virtual ICollection<Team> Teams1 { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
