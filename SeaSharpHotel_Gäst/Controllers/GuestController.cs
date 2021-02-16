using Microsoft.AspNetCore.Mvc;
using SeaSharpHotel_Gäst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaSharpHotel_Gäst.Controllers
{
    public class GuestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //skapar ny guest
            List<Guest> guests = new List<Guest>();
            //http call out backend
            HttpClient client = new HttpClient();
            //for respons vi måste publish innan jag kan lägga in url annars blir et bara localhostadress
            var respons = await client.GetAsync("");
            return View();
        }
    }
}
