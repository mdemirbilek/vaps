//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VERPSWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwWHMonthly
    {
        public int Id { get; set; }
        public string Id2 { get; set; }
        public System.DateTime WorkingDate { get; set; }
        public int RecYear { get; set; }
        public int RecMonth { get; set; }
        public int RecDay { get; set; }
        public string DayOfWeek { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
        public Nullable<System.DateTime> ExitTime { get; set; }
        public Nullable<int> AssignedWorkingHour { get; set; }
        public Nullable<int> AcceptedOTeHrs { get; set; }
        public Nullable<int> AcceptedOTMin { get; set; }
        public Nullable<bool> IsOTAccepted { get; set; }
        public Nullable<int> HourDiff { get; set; }
        public Nullable<int> MinuteDiff { get; set; }
        public Nullable<int> TotalHours { get; set; }
        public Nullable<int> TotalMinutes { get; set; }
        public string Exception { get; set; }
        public string Note { get; set; }
        public string UserStory { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
    }
}
