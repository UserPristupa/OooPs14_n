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
    
    public partial class History_replace_sotr
    {
        public int id_hrs { get; set; }
        public int id_sotr { get; set; }
        public Nullable<int> from_id_otd { get; set; }
        public Nullable<int> to_id_otd { get; set; }
        public Nullable<System.DateTime> date_replace { get; set; }
        public Nullable<int> from_id_dolzh { get; set; }
        public Nullable<int> to_id_dolzh { get; set; }
    
        public virtual Dolzhnosti Dolzhnosti { get; set; }
        public virtual Dolzhnosti Dolzhnosti1 { get; set; }
        public virtual Otdely Otdely { get; set; }
        public virtual Otdely Otdely1 { get; set; }
        public virtual Sotrudniki Sotrudniki { get; set; }
    }
}
