using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCandidatos.Models;
using SistemaDeCandidatos.Repositorios;

namespace SistemaDeCandidatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IIUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IIUsuarioRepositorio usuarioRepositorio) 
        { 
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
           List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{cpf}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorCPF(int cpf)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarPorCPF(cpf);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
            return Ok(usuario);
        }

        // Endpoint para deletar um usuário pelo CPF
        [HttpDelete("{cpf}")]
        public async Task<IActionResult> DeleteUsuario(int cpf)
        {
            try
            {
                var deleted = await _usuarioRepositorio.Apagar(cpf);
                if (deleted)
                {
                    return Ok($"Usuário com CPF {cpf} foi deletado com sucesso.");
                }
                else
                {
                    return NotFound($"Usuário com CPF {cpf} não encontrado.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro ao excluir o usuário: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int cpf, UsuarioModel usuario)
        {
            try
            {
                var existingUsuario = await _usuarioRepositorio.BuscarPorCPF(cpf);
                if (existingUsuario == null)
                {
                    return NotFound($"Usuário com CPF {cpf} não encontrado.");
                }

                existingUsuario.Nome = usuario.Nome;
                existingUsuario.Email = usuario.Email;

                var updatedUsuario = await _usuarioRepositorio.Atualizar(existingUsuario, cpf);
                return Ok(updatedUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro ao atualizar o usuário: {ex.Message}");
            }
        }

    }
}
