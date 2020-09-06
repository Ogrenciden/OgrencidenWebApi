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

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserById(int userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            return user;
        }

        public async Task<List<Ad>> GetAllAd()
        {
            var ads = await _context.Ads.Include(p => p.Photos).Include(u => u.User).ToListAsync();
            return ads;
        }

        public async Task<Ad> GetAdById(int adId)
        {
            var ad = await _context.Ads.Include(p => p.Photos).FirstOrDefaultAsync(a => a.AdId == adId);
            return ad;
        }

        public async Task<List<Photo>> GetPhotosByAdId(int addId)
        {
            var adPhotos = await _context.Photos.Where(a => a.Ad.AdId == addId).ToListAsync();
            return adPhotos;
        }
        public async Task<List<FavAds>> GetFavAdses(int userId)
        {
            var favAds = await _context.FavAdses.Where(u => u.User.UserId == userId)
                .Where(adc => adc.User.FavAdses.Any(fa => fa.UserId == userId)).Include(a => a.Ad).ToListAsync();
            return favAds;
        }

        public async Task<List<Ad>> GetAdsByCategory(int categoryId)
        {
            var ads = await _context.Ads.Include(p => p.Photos).Where(ad => ad.Category.CategoryId == categoryId)
                .ToListAsync();
            return ads;
        }

        public async Task<List<Ad>> GetAdByCity(string cityName)
        {
            var ads = await _context.Ads.Include(p => p.Photos).Where(c => c.City == cityName).ToListAsync();
            return ads;
        }

        public async Task<List<Ad>> GetAdByDateAsc()
        {
            var ads = await _context.Ads.Include(p => p.Photos).OrderBy(d => d.AdDate).ToListAsync();
            return ads;
        }

        public async Task<List<Ad>> GetAdByDateDesc()
        {
            var ads = await _context.Ads.Include(p => p.Photos).OrderByDescending(a => a.AdDate).ToListAsync();
            return ads;
        }

        public async Task<List<Ad>> GetUserSoldAds(int userId)
        {
            var ads = await _context.Ads.Include(p => p.Photos).Where(u => u.User.UserId == userId).Where(u => u.IsSold).ToListAsync();
            return ads;
        }

        public async Task<List<Ad>> GetAllAds()
        {
            var ads = await _context.Ads.Include(p => p.Photos).ToListAsync();
            return ads;
        }
    }
}
