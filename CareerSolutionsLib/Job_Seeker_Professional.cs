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
    
    public partial class Job_Seeker_Professional
    {
        public int jsProfID { get; set; }
        public int jsID { get; set; }
        public string jsKeySkills { get; set; }
        public string jsPreferredIndustry { get; set; }
        public int jsYearOfExperience { get; set; }
        public string jsPrevCompName { get; set; }
        public string jsPrevJobTitle { get; set; }
        public string jsPrevJobDescription { get; set; }
    
        public virtual Job_Seeker Job_Seeker { get; set; }
    }
}
