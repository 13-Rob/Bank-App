using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using BankApp.Data;
using BankApp.Models;

public class PaymentsController : Controller {
    // private readonly MvcPaymentContext _context;

    // public PaymentsController(MvcPaymentContext context) {
    //     _context = context;
    // }

    public IActionResult Index() {
        return View();
    }
}