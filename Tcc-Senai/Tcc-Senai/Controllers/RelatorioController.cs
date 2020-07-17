using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCC_Senai.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        private VendasDbContext db = new VendasDbContext();
        public ActionResult RelatorioStock(int? pagina, Boolean? pdf)
        {
            var listaStock = db.Stock.OrderBy(c => c.ProductId).ToList();
        }
}