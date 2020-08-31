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
            var ads = _context.Ads.ToList();
            return ads;
        }

        public Ad GetAdById(int adId)
        {
            var ad = _context.Ads.Include(p => p.Photos).FirstOrDefault(a => a.AdId == adId);
            return ad;
        }

        public List<Photo> GetPhotosByAdId(int addId)
        {
            var adPhotos = _context.Photos.Where(p => p.Ad.AdId == addId).ToList();
            return adPhotos;
        }
        public List<FavAds> GetFavAdses(int userId, int adId)
        {
            var favAds = _context.FavAdses.Where(u => u.User.UserId == userId).Where(a => a.Ad.AdId == adId).ToList();
            return favAds;
        }
    }
}
