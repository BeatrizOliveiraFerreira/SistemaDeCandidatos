using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeCandidatos.Models;

namespace SistemaDeCandidatos.Repositorios
{
    public interface IIUsuarioRepositorio
    {
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<bool> Apagar(int cpf);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int cpf);
        Task<UsuarioModel> BuscarPorCPF(int cpf);
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
    }
}
