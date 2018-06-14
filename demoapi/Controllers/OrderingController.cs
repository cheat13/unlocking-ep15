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
        [HttpPost]
        public string ProductOrder([FromBody]Ordering orderInfo)
        {
            // บันทึกข้อมูลการสั่งซื้อ
            return "A0001";
        }
    }
}