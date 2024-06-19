using Demo_01_UI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Demo_01_UI.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public RegionsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        // Get all regions function
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<RegionDTO> responeResult = new List<RegionDTO>();
            try
            {
                // Get all regions from api
                var client = httpClientFactory.CreateClient();

                var respone = await client.GetAsync("https://localhost:7038/api/regions");
                respone.EnsureSuccessStatusCode();

                // Add list respone to result
                responeResult.AddRange(await respone.Content.ReadFromJsonAsync<IEnumerable<RegionDTO>>());
            }
            catch (Exception)
            {

                throw;
            }

            return View(responeResult);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRegionViewModel request)
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:7038/api/regions"),
                    Method = HttpMethod.Post,
                    Content = new StringContent(JsonSerializer.Serialize(request),
                        encoding: Encoding.UTF8, "application/json")
                };
                var client = httpClientFactory.CreateClient();
                var respone = await client.SendAsync(httpRequestMessage);
                respone.EnsureSuccessStatusCode();

                var responeResult = await respone.Content.ReadFromJsonAsync<RegionDTO>();

                // Check if respone is not null
                if (responeResult != null)
                    return RedirectToAction("Index", "Regions");
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            try
            {
                var client = httpClientFactory.CreateClient();
                var respone = await client.GetFromJsonAsync<UpdateRegionViewModel>($"https://localhost:7038/api/regions/{id}");
                return View(respone);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateRegionViewModel request)
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri($"https://localhost:7038/api/regions/{request.Id}"),
                    Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json")
                };

                var client = httpClientFactory.CreateClient();
                var respone = await client.SendAsync(httpRequestMessage);
                respone.EnsureSuccessStatusCode();

                var responeResult = respone.Content.ReadFromJsonAsync<RegionDTO>();

                if (responeResult != null) return RedirectToAction("Index", "Regions");
                return View(null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateRegionViewModel request)
        {
            try
            {
                var client = httpClientFactory.CreateClient();
                await client.DeleteAsync($"https://localhost:7038/api/regions/{request.Id}");
                return RedirectToAction("Index", "Regions");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
