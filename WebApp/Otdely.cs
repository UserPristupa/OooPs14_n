//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Otdely
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Otdely()
        {
            this.Documents = new HashSet<Documents>();
            this.History_replace_sotr = new HashSet<History_replace_sotr>();
            this.History_replace_sotr1 = new HashSet<History_replace_sotr>();
            this.Sotrudniki1 = new HashSet<Sotrudniki>();
        }
    
        public int id_otd { get; set; }
        public string name_otd { get; set; }
        public Nullable<int> id_otd_parent { get; set; }
        public Nullable<System.DateTime> date_birth { get; set; }
        public Nullable<System.DateTime> date_death { get; set; }
        public Nullable<int> id_nach { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documents> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History_replace_sotr> History_replace_sotr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History_replace_sotr> History_replace_sotr1 { get; set; }
        public virtual Sotrudniki Sotrudniki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudniki> Sotrudniki1 { get; set; }
    }
}
