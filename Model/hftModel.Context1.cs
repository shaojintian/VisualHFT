﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisualHFT.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HFTEntities : DbContext
    {
        public HFTEntities()
            : base("name=HFTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StrategyParameter> StrategyParameters { get; set; }
        public virtual DbSet<CloseExecution> CloseExecutions { get; set; }
        public virtual DbSet<OpenExecution> OpenExecutions { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<STRATEGY_PARAMETERS_FIRMBB> STRATEGY_PARAMETERS_FIRMBB { get; set; }
        public virtual DbSet<STRATEGY_PARAMETERS_HFTACCEPTOR> STRATEGY_PARAMETERS_HFTACCEPTOR { get; set; }
        public virtual DbSet<STRATEGY_PARAMETERS_BBOOK> STRATEGY_PARAMETERS_BBOOK { get; set; }
        public virtual DbSet<STRATEGY_PARAMETERS_FIRMMM> STRATEGY_PARAMETERS_FIRMMM { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
    }
}
