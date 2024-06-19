using Microsoft.AspNetCore.Mvc;
using Demo_01_UI.Models.DTOs;

namespace Demo_01_UI.Controllers
{
    public class WalksController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public WalksController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<WalkDTO> responeResult = new List<WalkDTO>();
            try
            {
                var client = httpClientFactory.CreateClient();

                var respone = await client.GetAsync("https://localhost:7038/api/walks");
                respone.EnsureSuccessStatusCode();

                responeResult.AddRange(await respone.Content.ReadFromJsonAsync<IEnumerable<WalkDTO>>());
            }catch (Exception)
            {

            }
            return View(responeResult);
        }
    }
}
