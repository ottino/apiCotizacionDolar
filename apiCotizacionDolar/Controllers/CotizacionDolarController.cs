using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiCotizacionDolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionDolarController : ControllerBase
    {
        private string url;

        public CotizacionDolarController()
        {
            this.url = "https://www.infobae.com/economia/divisas/dolar-hoy/";
        }

        private string GetCleanDolarValue(string html)
        {
            Match match = Regex.Match(html, @"[\d,]+");
            if (match.Success)
            {
                return match.Value.Replace(",", ".");
            }
            return null;
        }

        private string ExtractDolarValue(HtmlDocument doc, string xpath)
        {
            var node = doc.DocumentNode.SelectSingleNode(xpath);
            if (node != null)
            {
                string innerHtml = node.InnerHtml;
                return GetCleanDolarValue(innerHtml);
            }
            return null;
        }

        [HttpGet("obtenerDolarBNA")]
        public ActionResult<object> ObtenerDolarBNA()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(this.url);

            string dolarValue = ExtractDolarValue(doc, "//a[@class='exchange-dolar-title']/following-sibling::p[@class='exchange-dolar-amount']");

            if (dolarValue != null)
            {
                return new { cotizacionBNA = dolarValue };
            }
            return NotFound("No se encontró la cotización del dólar");
        }

        [HttpGet("obtenerDolarLibre")]
        public ActionResult<object> ObtenerDolarLibre()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(this.url);

            string dolarValue = ExtractDolarValue(doc, "//a[@aria-label='Dólar Libre']/following-sibling::p");

            if (dolarValue != null)
            {
                return new { cotizacionDL = dolarValue };
            }
            return NotFound("No se encontró la cotización del Dólar Libre");
        }
    }
}

