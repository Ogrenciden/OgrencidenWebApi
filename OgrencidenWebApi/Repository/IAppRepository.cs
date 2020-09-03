using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgrencidenWebApi.Models;

namespace OgrencidenWebApi.Repository
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        User GetUserById(int userId);
        List<Ad> GetAllAd();
        Ad GetAdById(int adId);
        IQueryable<Photo> GetPhotosByAdId(int addId);
        IQueryable<FavAds> GetFavAdses(int userId);
        List<Ad> GetAdsByCategory(int categoryId);
        List<Ad> GetAdByCity(string cityName);
        List<Ad> GetAdByDateAsc();
        List<Ad> GetAdByDateDesc();

        IQueryable<Ad> GetUserSoldAds(int userId);





    }
}
