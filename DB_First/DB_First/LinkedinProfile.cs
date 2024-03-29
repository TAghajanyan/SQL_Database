//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class LinkedinProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LinkedinProfile()
        {
            this.LinkedinEducations = new HashSet<LinkedinEducation>();
            this.LinkedinExperiences = new HashSet<LinkedinExperience>();
            this.LinkedinInterests = new HashSet<LinkedinInterest>();
            this.LinkedinLanguages = new HashSet<LinkedinLanguage>();
            this.LinkedinSkills = new HashSet<LinkedinSkill>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Location { get; set; }
        public string Education { get; set; }
        public string Company { get; set; }
        public Nullable<int> ConnectionCount { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public Nullable<System.DateTime> Connected { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinEducation> LinkedinEducations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinExperience> LinkedinExperiences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinInterest> LinkedinInterests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinLanguage> LinkedinLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinSkill> LinkedinSkills { get; set; }
    }
}
