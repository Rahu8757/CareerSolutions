//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerSolutionsLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobs_Posted
    {
        public int jobID { get; set; }
        public int companyID { get; set; }
        public string jobIndustry { get; set; }
        public string jobKeySkills { get; set; }
        public string JobTitle { get; set; }
        public string jobDescription { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
