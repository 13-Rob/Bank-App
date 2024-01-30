using System;
using BankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Data {
    public class MvcPaymentContext : DbContext {
        public MvcPaymentContext(DbContextOptions<MvcPaymentContext> options) : base(options) {
        }

        public DbSet<Payment> Payment { get; set;}
    }
}