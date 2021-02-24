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
    
    public partial class court_officer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public court_officer()
        {
            this.complaint = new HashSet<complaint>();
            this.prisoner_transfer_request = new HashSet<prisoner_transfer_request>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string image { get; set; }
        public string appointment_date { get; set; }
        public string retirement_date { get; set; }
        public int in_service { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<complaint> complaint { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prisoner_transfer_request> prisoner_transfer_request { get; set; }
    }
}
