using System;
using BankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Data {
    public class PaymentContext : DbContext {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) {
        }

        public DbSet<Payment> Payment { get; set;}
    }
}