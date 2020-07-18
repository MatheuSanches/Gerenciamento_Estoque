using Rotativa;
using System.Web.Mvc;
using TCC_Senai.Models.RelStock;


namespace TCC_Senai.Controllers.Relatorio
{
    [Authorize(Roles ="")]//Permissão para Funcionário e ou Gerente
    public class RelatorioStockController : Controller
    {
        public ActionResult Index() 
        {
            var stock = RelStock.RelatorioStockGet();//Retorna Relatório
            return new ViewAsPdf("~/Views/Relatorio/RelatorioStock.cshtml", stock);//Retorna como PDF
        }
    }
}