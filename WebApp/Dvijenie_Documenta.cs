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
    
    public partial class Dvijenie_Documenta
    {
        public int id_dv_doc { get; set; }
        public int id_doc { get; set; }
        public System.DateTime data_sob { get; set; }
        public int id_type_dvij { get; set; }
        public int id_contag { get; set; }
        public int id_otd { get; set; }
        public int id_sotr { get; set; }
    
        public virtual Documents Documents { get; set; }
    }
}
