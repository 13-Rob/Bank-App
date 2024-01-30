using BankApp.Data;
using Microsoft.AspNetCore.Mvc;

public class PaymentsController : Controller {
    private readonly MvcPaymentContext _context;

    public PaymentsController(MvcPaymentContext context) {
        _context = context;
    }
}