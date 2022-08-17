using Microsoft.AspNetCore.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AntheapRekrutacjaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrzedsiebiorcyController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Subject>>> Get()
        {
            string api = "https://wl-api.mf.gov.pl/api/search/nip/";
            string nip= "";
            while (nip.Length != 10)
            {
                if (nip.Length != 10)
                    Console.WriteLine("Bledny nip, podaj 10 cyfr");
                Console.WriteLine("Podaj nip: ");
                nip = Console.ReadLine();
            }
            string b= "2022-06-23";
            string options = nip + "?date=" + b;
            WebClient client = new WebClient();
            string test = client.DownloadString(api + options);
            var przedsiebiorca  = JsonConvert.DeserializeObject<Root>(test);
            return Ok(przedsiebiorca);
        }
    }
}
