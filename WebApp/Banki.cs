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
    
    public partial class Banki
    {
        public int id_bank { get; set; }
        public int name_banka { get; set; }
        public int id_strana { get; set; }
        public int kod_banka { get; set; }
    
        public virtual Strana Strana { get; set; }
    }
}