//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WowCaseApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attribute()
        {
            this.AttributesInForm = new HashSet<AttributeInForm>();
            this.AttributesInReport = new HashSet<AttributeInReport>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Indexed { get; set; }
        public bool Nullable { get; set; }
        public string DBName { get; set; }
        public string IsFKey { get; set; }
        public bool IsPKey { get; set; }
    
        public virtual Table Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttributeInForm> AttributesInForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttributeInReport> AttributesInReport { get; set; }
    }
}
