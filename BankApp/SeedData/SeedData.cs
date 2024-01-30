using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using BankApp.Data;

namespace BankApp.Models;

public static class SeedData {
    public static void Initialize(IServiceProvider serviceProvider) {
        using (var context = new PaymentContext(serviceProvider.GetRequiredService<DbContextOptions<PaymentContext>>())) {
            if (context.Payment.Any()) {
                return;
            }

            context.Payment.AddRange(
                new Payment {
                    Description = "Rent",
                    Date = DateTime.Parse("2021-01-01"),
                    Amount = 1000.00M
                },
                new Payment {
                    Description = "Car Payment",
                    Date = DateTime.Parse("2021-01-01"),
                    Amount = 500.00M
                },
                new Payment {
                    Description = "Groceries",
                    Date = DateTime.Parse("2021-01-01"),
                    Amount = 200.00M
                },
                new Payment {
                    Description = "Car Insurance",
                    Date = DateTime.Parse("2021-01-01"),
                    Amount = 100.00M
                }
            );
            context.SaveChanges();
        }
    }
}
