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
    
    public partial class hrEmpMilService
    {
        public int Id { get; set; }
        public bool IsThereRelationship { get; set; }
        public string MilitaryRank { get; set; }
        public string MilSpecializationNr { get; set; }
        public string RecordInArmy { get; set; }
        public string MilServiceCardNr { get; set; }
        public string AssignmentPolishMil { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual hrPeople hrPeople { get; set; }
    }
}
