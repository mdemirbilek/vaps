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
    
    public partial class sylPrerequisite
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int Prerequisite_Course { get; set; }
        public int Prerequisite_Syllabus { get; set; }
    
        public virtual sylCours sylCours { get; set; }
        public virtual sylSyllabi sylSyllabi { get; set; }
    }
}
