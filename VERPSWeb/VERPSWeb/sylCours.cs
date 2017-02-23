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
    
    public partial class sylCours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sylCours()
        {
            this.hrEmpCourses = new HashSet<hrEmpCours>();
            this.plActivities = new HashSet<plActivity>();
            this.sylPrerequisites = new HashSet<sylPrerequisite>();
            this.sylProgramCourses = new HashSet<sylProgramCours>();
            this.sylSyllabis = new HashSet<sylSyllabi>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int Course_AcademicDepartment { get; set; }
        public int sylCourse_erpLanguage { get; set; }
        public int sylCourse_acaStudyMode { get; set; }
        public int sylCourse_acaDegree { get; set; }
        public int sylCourse_acaStudyProfile { get; set; }
    
        public virtual acaDegree acaDegree { get; set; }
        public virtual acaStudyMode acaStudyMode { get; set; }
        public virtual acaStudyProfile acaStudyProfile { get; set; }
        public virtual erpAcademicDepartment erpAcademicDepartment { get; set; }
        public virtual erpLanguage erpLanguage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmpCours> hrEmpCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plActivity> plActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sylPrerequisite> sylPrerequisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sylProgramCours> sylProgramCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sylSyllabi> sylSyllabis { get; set; }
    }
}