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
    
    public partial class plActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEN { get; set; }
        public int TotalHours { get; set; }
        public int ECTS { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int plActivity_erpLanguage { get; set; }
        public int plActivity_acaDegree { get; set; }
        public int plActivity_acaSemester { get; set; }
        public int plActivity_acaStudyMode { get; set; }
        public int plActivity_acaStudentSet { get; set; }
        public int plActivity_acaActivityType { get; set; }
        public int plActivity_acaObligationType { get; set; }
        public int plActivity_acaEvalType { get; set; }
        public int plActivity_acaRoomType { get; set; }
        public int plActivity_sylCourse { get; set; }
        public int plActivity_hrPerson1 { get; set; }
    
        public virtual acaActivityType acaActivityType { get; set; }
        public virtual acaDegree acaDegree { get; set; }
        public virtual acaEvalType acaEvalType { get; set; }
        public virtual acaObligationType acaObligationType { get; set; }
        public virtual acaRoomType acaRoomType { get; set; }
        public virtual acaSemester acaSemester { get; set; }
        public virtual acaStudentSet acaStudentSet { get; set; }
        public virtual acaStudyMode acaStudyMode { get; set; }
        public virtual erpLanguage erpLanguage { get; set; }
        public virtual hrPeople hrPeople { get; set; }
        public virtual sylCours sylCours { get; set; }
    }
}
