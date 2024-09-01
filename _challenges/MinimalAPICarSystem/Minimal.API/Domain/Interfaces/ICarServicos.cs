
using MinimalAPI.Domain.DTOs;
using MinimalAPI.Domain.Entities;

namespace Minimal.API.Domain.Interfaces
{
    public interface ICarServicos
    {
        List<Car> Todos(int pagina, string nome = null, string? marca = null);

        Car? BuscarPorId(string id);
        Car Incluir(Car car);
        Car Atualizar(Car car);
        Car Remover(Car car);
    }
}