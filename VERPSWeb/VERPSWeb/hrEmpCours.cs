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
    
    public partial class hrEmpCours
    {
        public int Id { get; set; }
        public string Semestry { get; set; }
        public string Term { get; set; }
        public decimal PlannedHours { get; set; }
        public decimal RealizedHours { get; set; }
        public string OtherInfo { get; set; }
        public Nullable<bool> ClassTypeCviczenia { get; set; }
        public Nullable<bool> ClassTypeWyklad { get; set; }
        public Nullable<bool> ClassTypeKonwersatoria { get; set; }
        public Nullable<bool> ClassTypeSeminarium { get; set; }
        public Nullable<bool> ClassTypeKonsultacje { get; set; }
        public Nullable<bool> ClassTypeEgzamin { get; set; }
        public Nullable<int> StudentSemestr { get; set; }
        public string WeekDay { get; set; }
        public string Dates { get; set; }
        public decimal ConductedHours { get; set; }
        public string Room { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int hrEmpCourse_erpHRAccountingPeriod { get; set; }
        public int hrEmpCourse_erpLanguage { get; set; }
        public int hrEmpCourse_hrEmpAcademicProfileByHR { get; set; }
        public int hrEmpCourse_hrPerson { get; set; }
        public int hrEmpCourse_sylCourse { get; set; }
    
        public virtual erpHRAccountingPeriod erpHRAccountingPeriod { get; set; }
        public virtual erpLanguage erpLanguage { get; set; }
        public virtual hrEmpAcademicProfileByHR hrEmpAcademicProfileByHR { get; set; }
        public virtual hrEvalStatu hrEvalStatu { get; set; }
        public virtual hrPeople hrPeople { get; set; }
        public virtual sylCours sylCours { get; set; }
    }
}
