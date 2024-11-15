using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using MongoDBProject.Services.OrderServices;


namespace MongoDBProject.Controllers
{
    public class PdfReportController : Controller
    {
        private readonly IOrderService _orderService;

        public PdfReportController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult PdfList()
        {
            return View();
        }

        public async Task<IActionResult> StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "orderlist.pdf");
            var stream = new FileStream(path, FileMode.Create);

           Document document = new Document(PageSize.A4);
           PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Ürün Adı");
            pdfPTable.AddCell("Ürün Adedi");
            pdfPTable.AddCell("Müsteri Adı");

            var model = await _orderService.GetOrderListViewModels();
            foreach (var item in model)
            {
                pdfPTable.AddCell(item.OrderProductName);
                pdfPTable.AddCell(item.OrderProductPiece);
                pdfPTable.AddCell(item.Customer.CustomerNameSurname);
            }

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/orderlist.pdf", "application/pdf", "orderlist.pdf");
        }
    }
}
