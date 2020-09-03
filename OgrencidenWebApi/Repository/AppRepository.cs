using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OgrencidenWebApi.Data;
using OgrencidenWebApi.Models;

namespace OgrencidenWebApi.Repository
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<User> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetUserById(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            return user;
        }

        public List<Ad> GetAllAd()
        {
            var ads = _context.Ads.Include(p => p.Photos).Include(u => u.User).ToList();
            return ads;
        }

        public Ad GetAdById(int adId)
        {
            var ad = _context.Ads.Include(p => p.Photos).FirstOrDefault(a => a.AdId == adId);
            return ad;
        }

        public IQueryable<Photo> GetPhotosByAdId(int addId)
        {
            var adPhotos = _context.Photos.Where(a => a.Ad.AdId == addId);
            return adPhotos;
        }
        public IQueryable<FavAds> GetFavAdses(int userId)
        {
            var favAds = _context.FavAdses.Where(u => u.User.UserId == userId)
                .Where(adc => adc.User.FavAdses.Any(fa => fa.UserId == userId)).Include(a => a.Ad);
            return favAds;
        }

        public List<Ad> GetAdsByCategory(int categoryId)
        {
            var ads = _context.Ads.Include(p => p.Photos).Where(ad => ad.Category.CategoryId == categoryId).ToList();
            return ads;
        }

        public List<Ad> GetAdByCity(string cityName)
        {
            var ads = _context.Ads.Include(p => p.Photos).Where(c => c.City == cityName).ToList();
            return ads;
        }

        public List<Ad> GetAdByDateAsc()
        {
            var ads = _context.Ads.Include(p => p.Photos).OrderBy(d => d.AdDate).ToList();
            return ads;
        }

        public List<Ad> GetAdByDateDesc()
        {
            var ads = _context.Ads.Include(p => p.Photos).OrderByDescending(a => a.AdDate).ToList();
            return ads;
        }

        public IQueryable<Ad> GetUserSoldAds(int userId)
        {
            var ads = _context.Ads.Include(p => p.Photos).Where(u => u.User.UserId == userId).Where(u => u.IsSold);
            return ads;
        }
    }
}
