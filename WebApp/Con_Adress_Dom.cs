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
    
    public partial class Con_Adress_Dom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Con_Adress_Dom()
        {
            this.Con_adress_Point = new HashSet<Con_adress_Point>();
        }
    
        public int id_con_adr_dom { get; set; }
        public int id_ulica { get; set; }
        public string nomer_name_doma { get; set; }
    
        public virtual Ulica Ulica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Con_adress_Point> Con_adress_Point { get; set; }
    }
}