using SmartMvc.Admin.Models;
using SmartMvc.Application.Interfaces;
using SmartMvc.Domain.Entities;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SmartMvc.Admin.Controllers
{
    public class MovimentBoxController : Controller
    {
        private readonly IBoxAppService _boxAppService;
        private readonly IMovimentBoxAppService _movimentBoxAppService;
        private readonly IInvoiceAppService _invoiceAppService;

        public MovimentBoxController(IBoxAppService boxAppService, IMovimentBoxAppService movimentBoxAppService, IInvoiceAppService invoiceAppService)
        {
            _boxAppService = boxAppService;
            _movimentBoxAppService = movimentBoxAppService;
            _invoiceAppService = invoiceAppService;
        }
        // GET: MovimentBox
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMoviment(int invoiceId)
        {
            var query = _movimentBoxAppService.Find(x => x.Invoice.Id == invoiceId).Any();
            if (!query)
            {
                Invoice invoice = _invoiceAppService.Get(invoiceId);


                MovimentBox movimentBox = new MovimentBox
                {
                    Invoice = invoice,
                    TypeMoviment = "Saída",
                    InitialDate = DateTime.Now
                };

                _movimentBoxAppService.Create(movimentBox);

                return Json(new { movimentBox, JsonRequestBehavior.AllowGet });
            }
            else
            {
                return Json(new { success = false });
            }

        }

        protected override void Dispose(bool disposing)
        {
            _boxAppService.Dispose();
            _movimentBoxAppService.Dispose();
            _invoiceAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}