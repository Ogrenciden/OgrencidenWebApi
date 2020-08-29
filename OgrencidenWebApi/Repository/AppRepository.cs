using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgrencidenWebApi.Models;

namespace OgrencidenWebApi.Repository
{
    public class AppRepository : IAppRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Ad> GetAllAd()
        {
            throw new NotImplementedException();
        }

        public Ad GetAdById(int adId)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetPhotosByAdId(int addId)
        {
            throw new NotImplementedException();
        }

        public List<FavAds> GetFavAdses()
        {
            throw new NotImplementedException();
        }
    }
}
