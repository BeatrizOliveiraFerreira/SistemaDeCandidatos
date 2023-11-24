using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeCandidatos.Models;

namespace SistemaDeCandidatos.Repositorios.Interfaces
{
    public interface IIUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorCPF(int cpf);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int cpf);
        Task<bool> Apagar(int cpf);
    }
}

