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
        public IActionResult GetFavAds(int userId)
        {
            var ads = _appRepository.GetFavAdses(userId);
            return Ok(ads);
        }

        [HttpGet("getUser")]
        public IActionResult GetUser(int userId)
        {
            var user = _appRepository.GetUserById(userId);
            return Ok(user);
        }

        [HttpGet("getadbycity")]
        public IActionResult GetAdByCity(string cityName)
        {
            var ads = _appRepository.GetAdByCity(cityName);
            return Ok(ads);
        }

        [HttpGet("getadsbycategory")]
        public IActionResult GetAdsByCategory(int categoryId)
        {
            var ads = _appRepository.GetAdsByCategory(categoryId);
            return Ok(ads);
        }

        [HttpGet("getadbydateasc")]
        public IActionResult GetAdByDate()
        {
            var ads = _appRepository.GetAdByDateAsc();
            return Ok(ads);
        }
        [HttpGet("getadbydatedesc")]
        public IActionResult GetAdByDateDesc()
        {
            var ads = _appRepository.GetAdByDateDesc();
            return Ok(ads);
        }

        [HttpGet("getusersoldads")]
        public IActionResult GetUserSoldAds(int userId)
        {
            var ads = _appRepository.GetUserSoldAds(userId);
            return Ok(ads);
        }

        [HttpGet("getadbyid")]
        public IActionResult GetAdById(int adId)
        {
            var ads = _appRepository.GetAdById(adId);
            return Ok(ads);
        }

        [HttpGet("getadphotos")]
        public IActionResult GetAdPhotos(int adId)
        {
            var photos = _appRepository.GetPhotosByAdId(adId);
            return Ok(photos);

        }
    }
}
