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
    
    public partial class sylCourseMaterial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MaterialType { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Created { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int SyllabusMaterial_Syllabus { get; set; }
    
        public virtual sylSyllabi sylSyllabi { get; set; }
    }
}
