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
    
    public partial class sylAcademicalAim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sylAcademicalAim()
        {
            this.sylOutcomeAims = new HashSet<sylOutcomeAim>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string AimType { get; set; }
        public string AcademicYear { get; set; }
        public string StudyLevel { get; set; }
        public string Language { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int sylAcademicalAim_erpAcademicDepartment { get; set; }
    
        public virtual erpAcademicDepartment erpAcademicDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sylOutcomeAim> sylOutcomeAims { get; set; }
    }
}
