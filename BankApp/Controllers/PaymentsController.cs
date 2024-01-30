using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using BankApp.Data;
using BankApp.Models;

public class PaymentsController : Controller {
    private readonly PaymentContext _context;

    public PaymentsController(PaymentContext context) {
        _context = context;
    }

    public async Task<IActionResult> Index() {
        return View(await _context.Payment.ToListAsync());
    }
}