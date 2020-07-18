using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC_Senai.Models.Context;

namespace TCC_Senai.Models.RelStock
{
    public class RelStock
    {
        public static List<Stock> RelatorioStockGet()
        {
            var ret = new List<Stock>();

            using (var db = new SysgamesContext())
            {
                ret = db.Stocks
                    .OrderBy(x => x.ProductId)
                    .Select(x => new Stock()
                    {
                        ProductId = x.ProductId,
                        TotalAmmount = x.TotalAmmount,
                        AvailableAmmount = x.AvailableAmmount,
                        Product = x.Product
                    }).ToList();
            }

            return ret;
        }
    }
}