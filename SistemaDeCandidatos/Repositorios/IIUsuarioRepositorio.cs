using SistemaDeCandidatos.Models;

namespace SistemaDeCandidatos.Repositorios
{
    public interface IIUsuarioRepositorio
    {
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<bool> Apagar(int id);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<UsuarioModel> BuscarPorId(int id);
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
    }
}