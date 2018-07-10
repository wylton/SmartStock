using SmartMvc.Application.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace SmartMvc.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceAppService _invoiceAppService;
        private readonly IMovimentBoxAppService _movimentBoxAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService, IMovimentBoxAppService movimentBoxAppService)
        {
            _invoiceAppService = invoiceAppService;
            _movimentBoxAppService = movimentBoxAppService;
        }
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetInvoice(string keyNf)
        {
            //Verifica se Nota Existe
            var invoice = _invoiceAppService.All(@readonly: true).Where(x => x.KeyNf == keyNf).FirstOrDefault();

            if (invoice == null)
                return Json(new { success = false, message = "Nota Fiscal Não Encontrada!!!" });

            //Verifica se já existe uma movimentação com aquela Nota Fiscal
            var movimentBoxInvoiceExists = _movimentBoxAppService.Find(x => x.Invoice.Id == invoice.Id).Any();
            if (!movimentBoxInvoiceExists)
                return Json(new { invoice, success = true, create=true, JsonRequestBehavior.AllowGet });


            //Verifica se já existe uma movimentação fechada com aquela Nota Fiscal
            var movimentBoxInvoiceFinalized = _movimentBoxAppService.Find(x => x.Invoice.Id == invoice.Id && x.FinalDate != null).Any();
            if (movimentBoxInvoiceFinalized)
                return Json(new { invoice, success = false, message = "Nota Fiscal já conferida!", JsonRequestBehavior.AllowGet });

            //Verifica se já existe uma movimentação aberta com aquela Nota Fiscal
            var movimentBoxInvoiceInitial = _movimentBoxAppService.Find(x => x.Invoice.Id == invoice.Id && x.FinalDate == null).Any();
            if (!movimentBoxInvoiceFinalized)
                return Json(new { invoice, success = true });

            return Json(new { invoice, success = true, create=true });
        }
    }
}