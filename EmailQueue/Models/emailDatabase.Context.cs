﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailQueue.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiversityTraxEntities : DbContext
    {
        public DiversityTraxEntities()
            : base("name=DiversityTraxEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<emailQueueFailedLog> emailQueueFailedLog { get; set; }
        public virtual DbSet<emailQueueSuccessfulLogs> emailQueueSuccessfulLogs { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<emailQueue> emailQueue { get; set; }
    }
}
