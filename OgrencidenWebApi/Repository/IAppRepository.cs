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

        List<User> GetUsers();
        User GetUserById(int userId);
        List<Ad> GetAllAd();
        Ad GetAdById(int adId);
        List<Photo> GetPhotosByAdId(int addId);
        List<FavAds> GetFavAdses(int userId, int adId);




    }
}
