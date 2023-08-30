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
        [HttpGet("obtenerDolarBNA")]
        public ActionResult<object> ObtenerDolarBNA()
        {
            string url = "https://www.infobae.com/economia/divisas/dolar-hoy/"; // Reemplazar con la URL real
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            var dolarNode = doc.DocumentNode.SelectSingleNode("//a[@class='exchange-dolar-title']/following-sibling::p[@class='exchange-dolar-amount']");
            if (dolarNode != null)
            {
                string dolarValue = dolarNode.InnerHtml;

                // Utilizar expresión regular para extraer el valor con decimales
                Match match = Regex.Match(dolarValue, @"[\d,]+");
                if (match.Success)
                {
                    string cleanDolarValue = match.Value.Replace(",", ".");
                    return new { cotizacionBNA = cleanDolarValue };
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
