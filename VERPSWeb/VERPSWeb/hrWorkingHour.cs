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
    
    public partial class hrWorkingHour
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DoorSysID { get; set; }
        public string AccessCardID { get; set; }
        public System.DateTime WorkingDate { get; set; }
        public int RecYear { get; set; }
        public int RecMonth { get; set; }
        public int RecDay { get; set; }
        public string DayOfWeek { get; set; }
        public bool IsWorkingDay { get; set; }
        public int StdWorkingHour { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
        public Nullable<System.DateTime> ExitTime { get; set; }
        public Nullable<int> TotalHours { get; set; }
        public Nullable<int> TotalMinutes { get; set; }
        public string Exception { get; set; }
        public string Note { get; set; }
        public Nullable<int> AssignedWorkingHour { get; set; }
        public Nullable<int> HourDiff { get; set; }
        public Nullable<int> MinuteDiff { get; set; }
        public Nullable<bool> IsOTAccepted { get; set; }
        public string OTAcceptedBy { get; set; }
        public Nullable<int> AcceptedOTeHrs { get; set; }
        public Nullable<int> AcceptedOTMin { get; set; }
        public int EmpId { get; set; }
        public string UserStory { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int WorkingHour_Employee { get; set; }
    
        public virtual hrPeople hrPeople { get; set; }
    }
}
