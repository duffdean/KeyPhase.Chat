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
    
    public partial class TaskHistory
    {
        public int ID { get; set; }
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> DateSubmitted { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
