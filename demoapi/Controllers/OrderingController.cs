using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderingController : Controller
    {
        private static int runningNo;

        [HttpPost]
        public Billing ProductOrder([FromBody]Ordering orderInfo)
        {
            // บันทึกข้อมูลการสั่งซื้อ

            var totalPrice = ProductController
                .products
                .Where(it => orderInfo.ProductIds.Any(p => p == it.Id))
                .Sum(it => it.Price);
                
            runningNo++;

            return new Billing
            {
                Username = orderInfo.Username,
                ReferenceCode = "A00" + runningNo,
                Price = totalPrice
            };
        }
    }
}