//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProject1.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class crime_record
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string crime_date { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string description { get; set; }
        public Nullable<int> prisonerid { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string punishment { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string imprisonment_date { get; set; }
        public string release_date { get; set; }
    
        public virtual prisoner prisoner { get; set; }
    }
}
