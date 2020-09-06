using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OgrencidenWebApi.Repository;

namespace OgrencidenWebApi.Controllers
{
    [Route("api/ads")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        public AdsController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpGet]
        public IActionResult GetAds()
        {
            var ads = _appRepository.GetAllAd();

            return Ok(ads);
        }

        [HttpGet("getfavads")]
        public async Task<IActionResult> GetFavAds(int userId)
        {
            var ads = await _appRepository.GetFavAdses(userId);
            return Ok(ads);
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _appRepository.GetUserById(userId);
            return Ok(user);
        }

        [HttpGet("getadbycity")]
        public async Task<IActionResult> GetAdByCity(string cityName)
        {
            var ads = await _appRepository.GetAdByCity(cityName);
            return Ok(ads);
        }

        [HttpGet("getadsbycategory")]
        public async Task<IActionResult> GetAdsByCategory(int categoryId)
        {
            var ads = await _appRepository.GetAdsByCategory(categoryId);
            return Ok(ads);
        }

        [HttpGet("getadbydateasc")]
        public async Task<ActionResult> GetAdByDate()
        {
            var ads = await _appRepository.GetAdByDateAsc();
            return Ok(ads);
        }
        [HttpGet("getadbydatedesc")]
        public async Task<ActionResult> GetAdByDateDesc()
        {
            var ads = await _appRepository.GetAdByDateDesc();
            return Ok(ads);
        }

        [HttpGet("getusersoldads")]
        public async Task<IActionResult> GetUserSoldAds(int userId)
        {
            var ads = await _appRepository.GetUserSoldAds(userId);
            return Ok(ads);
        }

        [HttpGet("getadbyid")]
        public async Task<IActionResult> GetAdById(int adId)
        {
            var ads = await _appRepository.GetAdById(adId);
            return Ok(ads);
        }

        [HttpGet("getadphotos")]
        public async Task<IActionResult> GetAdPhotos(int adId)
        {
            var photos = await _appRepository.GetPhotosByAdId(adId);
            return Ok(photos);

        }
    }
}
