﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OooPs14_dbEntities2 : DbContext
    {
        public OooPs14_dbEntities2()
            : base("name=OooPs14_dbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adress_contragent> Adress_contragent { get; set; }
        public virtual DbSet<Arhiv_sotr> Arhiv_sotr { get; set; }
        public virtual DbSet<Banki> Banki { get; set; }
        public virtual DbSet<Buchalterya> Buchalterya { get; set; }
        public virtual DbSet<Chet_inBank> Chet_inBank { get; set; }
        public virtual DbSet<Con_Adress_Dom> Con_Adress_Dom { get; set; }
        public virtual DbSet<Con_adress_Point> Con_adress_Point { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Contragenti> Contragenti { get; set; }
        public virtual DbSet<Contragenti_contact> Contragenti_contact { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Dolzhnosti> Dolzhnosti { get; set; }
        public virtual DbSet<Dvijenie_Documenta> Dvijenie_Documenta { get; set; }
        public virtual DbSet<History_replace_sotr> History_replace_sotr { get; set; }
        public virtual DbSet<Mestnost> Mestnost { get; set; }
        public virtual DbSet<Otdely> Otdely { get; set; }
        public virtual DbSet<Prichina> Prichina { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudniki { get; set; }
        public virtual DbSet<Strana> Strana { get; set; }
        public virtual DbSet<Tip_Documenta> Tip_Documenta { get; set; }
        public virtual DbSet<Ulica> Ulica { get; set; }
        public virtual DbSet<Valyta> Valyta { get; set; }
        public virtual DbSet<Vid_Documenta> Vid_Documenta { get; set; }
    }
}
