//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberConnectProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Barber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barber()
        {
            this.Administrators = new HashSet<Administrator>();
        }
    
        public int BarberID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> ReviewID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual Barber Barber1 { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual LocationInfo LocationInfo { get; set; }
        public virtual Review Review { get; set; }
        public virtual SelectionPage SelectionPage { get; set; }
    }
}
