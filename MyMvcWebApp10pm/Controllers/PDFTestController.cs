using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using HiQPdf;
namespace MyMvcWebApp10pm.Controllers
{
    public class PDFTestController : Controller
    {
        // GET: PDFTest
      
 
            public ActionResult Index()
            {
                ViewBag.Message = "Welcome to ASP.NET MVC!";
                Session["MySessionVariable"] = "My Session Variable Value assigned in Index";
                return View();
            }

            public ActionResult About()
            {
                return View();
            }

            public string RenderViewAsString(string viewName, object model)
            {
                // create a string writer to receive the HTML code
                StringWriter stringWriter = new StringWriter();

                // get the view to render
                ViewEngineResult viewResult = ViewEngines.Engines.FindView(ControllerContext, viewName, null);
                // create a context to render a view based on a model
                ViewContext viewContext = new ViewContext(
                        ControllerContext,
                        viewResult.View,
                        new ViewDataDictionary(model),
                        new TempDataDictionary(),
                        stringWriter
                        );

                // render the view to a HTML code
                viewResult.View.Render(viewContext, stringWriter);

                // return the HTML code
                return stringWriter.ToString();
            }

            [HttpPost]
            public ActionResult ConvertThisPageToPdf()
            {
                // get the HTML code of this view
                string htmlToConvert = RenderViewAsString("Index", null);

                // the base URL to resolve relative images and css
                String thisPageUrl = this.ControllerContext.HttpContext.Request.Url.AbsoluteUri;
                String baseUrl = thisPageUrl.Substring(0, thisPageUrl.Length - "PDFTest/ConvertThisPageToPdf".Length);

                // instantiate the HiQPdf HTML to PDF converter
                HtmlToPdf htmlToPdfConverter = new HtmlToPdf();

                // hide the button in the created PDF
                htmlToPdfConverter.HiddenHtmlElements = new string[] { "#convertThisPageButtonDiv" };

                // render the HTML code as PDF in memory
                byte[] pdfBuffer = htmlToPdfConverter.ConvertHtmlToMemory(htmlToConvert, baseUrl);

                // send the PDF file to browser
                FileResult fileResult = new FileContentResult(pdfBuffer, "application/pdf");
                fileResult.FileDownloadName = "ThisMvcViewToPdf.pdf";

                return fileResult;
            }

            [HttpPost]
            public ActionResult ConvertAboutPageToPdf()
            {
                // get the About view HTML code
                string htmlToConvert = RenderViewAsString("About", null);

                // the base URL to resolve relative images and css
                String thisPageUrl = this.ControllerContext.HttpContext.Request.Url.AbsoluteUri;
                String baseUrl = thisPageUrl.Substring(0, thisPageUrl.Length - "PDFTest/ConvertAboutPageToPdf".Length);

                // instantiate the HiQPdf HTML to PDF converter
                HtmlToPdf htmlToPdfConverter = new HtmlToPdf();

                // render the HTML code as PDF in memory
                byte[] pdfBuffer = htmlToPdfConverter.ConvertHtmlToMemory(htmlToConvert, baseUrl);

                // send the PDF file to browser
                FileResult fileResult = new FileContentResult(pdfBuffer, "application/pdf");
                fileResult.FileDownloadName = "AboutMvcViewToPdf.pdf";

                return fileResult;
            }
        }
    }






