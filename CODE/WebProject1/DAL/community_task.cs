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

    public partial class community_task
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string task { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string date { get; set; }
        [Required(ErrorMessage = "Required!")]
        [Range(1, 100000, ErrorMessage = "Amount Cannot be negative")]
        public Nullable<int> amount { get; set; }
        public Nullable<int> prisonerid { get; set; }
    
        public virtual prisoner prisoner { get; set; }
    }
}
