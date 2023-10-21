using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        //API'ın Consume Edilmesi
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //İstemci oluşturduk.
            var responseMessage = await client.GetAsync("http://localhost:50430/api/Booking"); //Adrese istekte bulunduk.
            if (responseMessage.IsSuccessStatusCode) //Başarılı durum kodu dönerse
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync(); //Gelen veri jsondata değişkenine aktarıldı. jsondata json türünde.
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsondata); //Tablomuza verinin aktarılması için deserialize işlemi yapıldı.
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto approvedReservationDto)
        {
            approvedReservationDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(approvedReservationDto); //gelen veriyi json formatına çevir.
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:50430/api/Booking/ApprovedBooking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //End
    }
}
