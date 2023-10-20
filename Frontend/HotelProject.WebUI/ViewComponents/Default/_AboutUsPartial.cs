using HotelProject.WebUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); //İstemci oluşturduk.
            var responseMessage = await client.GetAsync("http://localhost:50430/api/About"); //Adrese istekte bulunduk.
            if (responseMessage.IsSuccessStatusCode) //Başarılı durum kodu dönerse
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync(); //Gelen veri jsondata değişkenine aktarıldı. jsondata json türünde.
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsondata); //Tablomuza verinin aktarılması için deserialize işlemi yapıldı.
                return View(values);
            }
            return View();
        }
    }
}