using Minimal.API.Domain.Interfaces;
using MinimalAPI.Domain.DTOs;
using MinimalAPI.Domain.Entities;
using MinimalAPI.Infrastructure.Db;

namespace Minimal.API.Domain.Services
{
    public class Carservicos : ICarservicos
    {
        private readonly DbCarContext _dbCarContext;

        public Carservicos(DbCarContext dbCarContext)
        {
            _dbCarContext = dbCarContext;
        }

        public Administrator? Login(LoginDTO loginDTO)
        {
            var adm = _dbCarContext.Administrators.Where(x => x.Email == loginDTO.Email && x.Password == loginDTO.Password).FirstOrDefault();
            return adm;
        }
    }
}