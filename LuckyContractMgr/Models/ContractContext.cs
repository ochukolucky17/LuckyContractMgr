using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LuckyContractMgr.Models
{
    public class ContractContext : DbContext
    {
        public ContractContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>().HasData(new Contract
            {
               Id = 1,
                VendorCompanyName = "Ochukwu Ltd",
                VendorContactPerson = "Lucky",
                RFQNumber = "RFQ000ZHRS",
                PONumber = "PO00234",
                ScopeOfWork = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                PaymentTerms = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                TerminationTerms = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                ContractExecutedOn = System.DateTime.Now,
                ContractTerminateOn = System.DateTime.Now

            }, new Contract
            {
                Id = 2,
                VendorCompanyName = "KK LImited",
                VendorContactPerson = "Lucky",
                RFQNumber = "RFQ00KHGS",
                PONumber = "PO00834",
                ScopeOfWork = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                PaymentTerms = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                TerminationTerms = "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.",
                ContractExecutedOn = System.DateTime.Now,
                ContractTerminateOn = System.DateTime.Now
            });

            modelBuilder.Entity<LoginModel>().HasData(new LoginModel
            {
                Id = 1,
                FullName = "Lucky Okorodiden",
                EmailAddress = "Lucky@ContractManager.com",
                Telephone = "081487282912",
                UserName = "Lucky1",
                Password = "Lucky@123"
            }, new LoginModel
            {
                Id = 2,
                FullName = "Lucky Okorodiden",
                EmailAddress = "Lucky@ContractManager.com",
                Telephone = "081487282912",
                UserName = "Lucky2",
                Password = "Lucky@123"
            }, new LoginModel
            {
                Id = 3,
                FullName = "Lucky Okorodiden",
                EmailAddress = "Lucky@ContractManager.com",
                Telephone = "081487282912",
                UserName = "Lucky3",
                Password = "Lucky@123"
            });
        }
    }
}
