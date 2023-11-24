# Sistema de Candidatos

Este é um projeto que implementa um sistema para gerenciar informações de candidatos usando ASP.NET Core e Entity Framework Core.

## Estrutura do Projeto

O projeto está dividido em duas partes principais:

### 1. Program.cs

O arquivo `Program.cs` configura o aplicativo web ASP.NET Core, define os serviços, incluindo controladores, configurações do Swagger para documentação da API e o contexto do Entity Framework para trabalhar com um banco de dados SQL Server.

### 2. UsuarioController.cs

O arquivo `UsuarioController.cs` é um controlador responsável por realizar operações CRUD (Create, Read, Update, Delete) relacionadas aos usuários do sistema. Ele possui endpoints para:

- `GET /api/Usuario`: Retorna todos os usuários cadastrados.
- `GET /api/Usuario/{id}`: Retorna um usuário específico com o ID fornecido.
- `POST /api/Usuario`: Cria um novo usuário com base nos dados fornecidos no corpo da requisição.
- `DELETE /api/Usuario/{id}`: Remove um usuário com o ID especificado.
- `PUT /api/Usuario/{id}`: Atualiza um usuário existente com o ID fornecido usando os dados fornecidos no corpo da requisição.

## Configuração

Para executar o projeto localmente, siga estas etapas:

1. Clone este repositório.
2. Certifique-se de ter o .NET SDK instalado.
3. Configure a conexão com o banco de dados no arquivo `appsettings.json`.
4. Execute o aplicativo usando o comando `dotnet run`.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para propor melhorias, relatar problemas ou enviar pull requests.

## Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
