using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUser;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient(); //İstemci oluşturduk.
            var responseMessage = await client.GetAsync("http://localhost:50430/api/AppUser/"); //Adrese istekte bulunduk.
            if (responseMessage.IsSuccessStatusCode) //Başarılı durum kodu dönerse
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync(); //Gelen veri jsondata değişkenine aktarıldı. jsondata json türünde.
                var values = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsondata); //Tablomuza verinin aktarılması için deserialize işlemi yapıldı.
                return View(values);
            }
            return View();
        }
    }
}
