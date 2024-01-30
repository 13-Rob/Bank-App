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

    // GET: /Payments
    public async Task<IActionResult> Index() {
        return View(await _context.Payment.ToListAsync());
    }

    // GET: /Payments/Create
    public IActionResult Create() {
        return View();
    }

    // POST /Payments/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Description,Date,Amount")] Payment payment) {
        if (ModelState.IsValid) {
            _context.Add(payment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(payment);
    }

    // GET: /Payments/Details/5
    public async Task<IActionResult> Details(int? id) {
        if (id == null) {
            return NotFound();
        }

        var payment = await _context.Payment.FirstOrDefaultAsync(m => m.Id == id);
        if (payment == null) {
            return NotFound();
        }
        return View(payment);
    }

    // GET: /Payments/Edit/5
    public async Task<IActionResult> Edit(int? id) {
        if (id == null) {
            return NotFound();
        }

        var payment = await _context.Payment.FirstOrDefaultAsync(m => m.Id == id);
        if (payment == null) {
            return NotFound();
        }
        return View(payment);
    }
}