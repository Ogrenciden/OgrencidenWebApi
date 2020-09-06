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

        Task<User> GetUserById(int userId);
        Task<List<Ad>> GetAllAd();
        Task<Ad> GetAdById(int adId);
        Task<List<Photo>> GetPhotosByAdId(int addId);
        Task<List<FavAds>> GetFavAdses(int userId);
        Task<List<Ad>> GetAdsByCategory(int categoryId);
        Task<List<Ad>> GetAdByCity(string cityName);
        Task<List<Ad>> GetAdByDateAsc();
        Task<List<Ad>> GetAdByDateDesc();
        Task<List<Ad>> GetUserSoldAds(int userId);
        Task<List<Ad>> GetAllAds();



    }
}
