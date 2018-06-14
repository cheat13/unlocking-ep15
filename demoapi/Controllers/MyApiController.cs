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
    public class MyApiController : Controller
    {
        [HttpGet]
        public string Greeting()
        {
            return "Hello world";
        }

        [HttpGet("{name}")]
        public string Greeting(string name)
        {
            return "Hello " + name;
        }

        [HttpPost]
        public Product CreateNewProduct([FromBody]Product product)
        {
            // TODO: เดี๋ยวมาเขียน code เปลี่ยนรหัสสินค้าใหม่ ใช้ตัวนี้ชั่วคราวไปก่อน
            product.Id = 1234;
            // เพิ่มสินค้าใหม่ในระบบ
            return product;
        }

        [HttpPut("{id}")]
        public Product UpdateProductName(string id, [FromBody]Product product)
        {
            // แก้ไขชื่อสินค้าที่เลือกจากรหัสสินค้า
            return product;
        }
    }
}
