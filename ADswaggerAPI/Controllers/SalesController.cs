using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADswaggerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        SalesService salesService;
        public SalesController()
        {
            salesService = new SalesService();
        }
        // GET api/GetAllClass
        [HttpGet("All")]
        public ActionResult<List<Sales>> GetAllSales()
        {
            return salesService.GetAllSales();
        }

        [HttpGet("All/Revenue")]
        public ActionResult<List<GroupedRevenue>> GetGroupedRevenue()
        {
            return salesService.GetGroupedRevenue();
        }

        // [HttpGet("GetSalesByID/{id}")]
        // public Sales GetSalesByID(int id)
        // {
        //     return salesService.GetSalesByID(id);
        // }

        // [HttpGet("GetSalesByArticleNumber/{articlenumber}")]
        // public Sales GetSalesByArticleNumber(string articlenumber)
        // {
        //     return salesService.GetSalesByArticleNumber(articlenumber);
        // }

        [HttpGet("Daily")]
        public ActionResult<List<DailySales>> GetDailySalesCount()
        {
            return salesService.GetDailySalesCount();
        }

        [HttpGet("Daily/Revenue")]
        public ActionResult<List<TotalDailyRevenue>> GetTotalDailyRevenue()
        {
            return salesService.GetTotalDailyRevenue();
        }

        [HttpPost("Add/Sale")]
        public void AddSale([FromBody] Sales sales)
        {
            salesService.AddSale(sales);
        }
    }
}