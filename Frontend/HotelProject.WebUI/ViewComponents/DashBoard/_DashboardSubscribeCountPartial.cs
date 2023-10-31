using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.DashBoard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/melihdncrr_"),
                Headers =
    {
        { "X-RapidAPI-Key", "4989b69e0bmsh169542d11e74854p1241b2jsnf9e27d1a6ff4" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDtos.followers;
                ViewBag.v2 = resultInstagramFollowersDtos.following;
            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=m_dincer41"),
                Headers =
    {
        { "X-RapidAPI-Key", "4989b69e0bmsh169542d11e74854p1241b2jsnf9e27d1a6ff4" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v3 = resultInstagramFollowersDtos.data.user_info.followers_count;
                ViewBag.v4 = resultInstagramFollowersDtos.data.user_info.friends_count;             
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmelih-dincer%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "4989b69e0bmsh169542d11e74854p1241b2jsnf9e27d1a6ff4" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
                ViewBag.v5 = resultLinkedinFollowersDto.data.followers_count;
            }
            return View();
        }
    }
}
