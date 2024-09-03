
using MinimalAPI.Domain.DTOs;
using MinimalAPI.Domain.Entities;

namespace Minimal.API.Domain.Interfaces
{
    public interface IAdministradorServicos
    {
        Administrator Login(LoginDTO loginDTO);
    }
}