using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SammyCloudData.Entities;

namespace SammyCloudData.Contexts 
{
    public class SammyCloudContext: DbContext
    {

        private const string CONNECTION_STRING = "Server={0};Database=sammy_cloud_dev;User Id=sammy_cloud_dev;Password=Morgana1234;Persist Security Info=True;";
        public DbSet<IndexedValue> IndexedValues { get; set; }
        public DbSet<Account> Accounts { get; set; }
   
        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public SammyCloudContext(): base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string SERVER = "sammycloud.cogxoz0oube6.us-east-2.rds.amazonaws.com";
            optionsBuilder.UseNpgsql(string.Format(CONNECTION_STRING, SERVER));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
