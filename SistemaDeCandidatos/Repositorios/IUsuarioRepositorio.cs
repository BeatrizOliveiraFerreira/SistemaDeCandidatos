using Microsoft.EntityFrameworkCore;
using SistemaDeCandidatos.Data;
using SistemaDeCandidatos.Models;
using SistemaDeCandidatos.Repositorios.Interfaces;

namespace SistemaDeCandidatos.Repositorios
{
    public class UsuarioRepositorio: IIUsuarioRepositorio
    {
        private readonly SistemaTarefasDbContext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDbContext sistemaTarefasDbContext)
        {
            _dbContext = sistemaTarefasDbContext;
        }
        public async Task<UsuarioModel> BuscarPorCPF(int cpf)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.CPF == cpf);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
           await _dbContext.Usuarios.AddAsync(usuario);
           await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int cpf)
        {
            UsuarioModel usuarioPorCPF = await BuscarPorCPF(cpf);
            if (usuarioPorCPF == null)
            {
                throw new Exception($"Usuário para o CPF: {cpf} não foi encontrado no banco de dados");
            }

            usuarioPorCPF.Nome = usuario.Nome;
            usuarioPorCPF.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorCPF);
            await _dbContext.SaveChangesAsync();

            return usuarioPorCPF;
        }

        public async Task<bool> Apagar(int cpf)
        {
            UsuarioModel usuarioPorCPF = await BuscarPorCPF(cpf);
            if (usuarioPorCPF == null)
            {
                throw new Exception($"Usuário para o CPF: {cpf} não foi encontrado no banco de dados");
            }

            _dbContext.Usuarios.Remove(usuarioPorCPF);
           await _dbContext.SaveChangesAsync();
            return true;

        }




    }

}
