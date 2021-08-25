using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MambuCards.Models;
using System.Net.Http.Headers;
using System.Net;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json;
using MambuCards.entities;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace MambuCards.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        protected readonly IConfiguration _configuration;
        private static string serverBase = string.Empty;
        private static string credential = string.Empty;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
            serverBase =  _configuration.GetValue<string>("serverName");
            credential = _configuration.GetValue<string>("Credential");
        }

        public IActionResult Index()
        {
            var name = string.Empty;
            TempData["withoutContetntPage"] = "true";
            if (TempData.ContainsKey("signed_request"))
            {
                name = TempData["signed_request"].ToString();
            }

            ViewBag.object_id = name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetParameters(string accountId)
        {
            TempData["signed_request"] = accountId;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Index([FromForm] string signed_request)
        {
            
            try {
                var parts = signed_request.Split('.');
                string partA = parts[0];
                string partB = parts[1];
                byte[] data = HomeController.DecodeUrlBase64(partB);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                var decodeObject = JsonConvert.DeserializeObject<MambuRequest>(decodedString);

                ViewBag.object_id = decodeObject.OBJECT_ID;
                TempData["signed_request"] = decodeObject.OBJECT_ID;
            }
            catch (Exception ex)
            {
                ViewBag.Error = "There is an error with the configuration";
                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Revert(string cardToken, string externalReferenceId)
        {
            var resu = RevertAsync(cardToken, externalReferenceId);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Approve(string cardToken, string externalReferenceId)
        {
            var resu = ApproveAsync(cardToken, externalReferenceId).Result;
            return RedirectToAction("Index");
        }



        [HttpPost]
        public JsonResult LoadData(string encodekey)
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                //var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();

                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;


                List<Card> list = ListCardsAsync(encodekey).Result;
                // Getting all Customer data    
                var customerData = (from tempcustomer in list
                                    select tempcustomer);


                //Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    
                    customerData = customerData.Where(m => m.cardToken.Contains(searchValue) ||
                                                        m.externalReferenceId.Contains(searchValue) ||
                                                        m.encodedKey.Contains(searchValue) ||
                                                        m.status.Contains(searchValue) ||
                                                        m.advice.Contains(searchValue) ||
                                                        m.creditDebitIndicator.Contains(searchValue));
                }

                //total number of rows count     
                recordsTotal = customerData.Count();

                if (recordsTotal == 0)
                {
                    ViewBag.Error = "here are no cards for this account";
                }

                //Paging     
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data
                var dataRender = JsonConvert.SerializeObject(data);
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Json(jsonData);

            }
            catch (Exception)
            {
                throw;
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public static async Task<List<Card>> ListCardsAsync(string encodekey)
        {
            List<Card> list = new List<Card>();
            var clientEndpoint = string.Concat(serverBase, "/api/deposits/" , encodekey  , "/authorizationholds");

            HttpClient httpDataClient = new HttpClient();
            httpDataClient.DefaultRequestHeaders.Add("Accept", "application/vnd.mambu.v2+json");
            httpDataClient.DefaultRequestHeaders.Add("Authorization", credential);
            httpDataClient.DefaultRequestHeaders.Add("User-Agent", "MambuApp");
            httpDataClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var cts = new CancellationToken();

            var clientResponse = await httpDataClient.GetAsync(clientEndpoint, cts);
            if (clientResponse.StatusCode == HttpStatusCode.OK)
            {
                string result = clientResponse.Content.ReadAsStringAsync().Result;
                
                list = JsonConvert.DeserializeObject<List<Card>>(result);
            }

            return list;
        }

        public async Task<bool> RevertAsync(string cardToken, string externalReferenceId)
        {

            bool result = false;

            var clientEndpoint = string.Concat(serverBase, "/api/cards/{0}/authorizationholds/{1}");
            clientEndpoint = string.Format(clientEndpoint, cardToken, externalReferenceId);

            HttpClient httpDataClient = new HttpClient();
            httpDataClient.DefaultRequestHeaders.Add("Accept", "application/vnd.mambu.v2+json");
            httpDataClient.DefaultRequestHeaders.Add("Authorization", credential);
            httpDataClient.DefaultRequestHeaders.Add("User-Agent", "MambuApp");
            httpDataClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var cts = new CancellationToken();

            var clientResponse = await httpDataClient.DeleteAsync(clientEndpoint, cts);
            if (clientResponse.StatusCode == HttpStatusCode.OK)
            {
                result = true;
            }

            return result;
        }

        public static byte[] DecodeUrlBase64(string s)
        {
            s = s.Replace('-', '+').Replace('_', '/').PadRight(4 * ((s.Length + 3) / 4), '=');
            return Convert.FromBase64String(s);
        }

        public async Task<bool> ApproveAsync(string cardToken, string externalReferenceId)
        {
            Card card = new Card();
            var clientEndpoint = string.Concat(serverBase, "/api/cards/{0}/authorizationholds/{1}");
            clientEndpoint = string.Format(clientEndpoint, cardToken, externalReferenceId);
            HttpClient httpDataClient = new HttpClient();
            httpDataClient.DefaultRequestHeaders.Add("Accept", "application/vnd.mambu.v2+json");
            httpDataClient.DefaultRequestHeaders.Add("Authorization", credential);
            httpDataClient.DefaultRequestHeaders.Add("User-Agent", "MambuApp");
            httpDataClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var cts = new CancellationToken();

            var clientResponse = await httpDataClient.GetAsync(clientEndpoint, cts);
            if (clientResponse.StatusCode == HttpStatusCode.OK)
            {
                string result = clientResponse.Content.ReadAsStringAsync().Result;

                card = JsonConvert.DeserializeObject<Card>(result);
            }


            var authorizationHold = string.Concat(serverBase, "/api/cards/{0}/financialtransactions");
            authorizationHold = string.Format(authorizationHold, cardToken);
            var body = new { externalReferenceId = card.externalReferenceId + "Settle",
                advice = false,
                amount = card.amount,
                externalAuthorizationReferenceId = card.externalReferenceId,
                transactionChannelId="cash"};

            var dataRender = JsonConvert.SerializeObject(body);
            var data = new StringContent(dataRender, Encoding.UTF8, "application/json");
            clientResponse = await httpDataClient.PostAsync(authorizationHold, data, cts);
            if (clientResponse.StatusCode == HttpStatusCode.OK)
            {
                string result = clientResponse.Content.ReadAsStringAsync().Result;

                card = JsonConvert.DeserializeObject<Card>(result);
            }

            return true;

        }
    }
}
