# CRUDaspnet

Este projeto é um CRUD simples feito com ASP.NET Core Razor Pages, utilizando Entity Framework Core e SQLite como banco de dados.

## Funcionalidades

- Cadastro, edição, listagem e exclusão de **Students** (alunos)
- Cadastro, edição, listagem e exclusão de **Premiums** (assinaturas premium)
- Relacionamento entre Student e Premium

## Tecnologias Utilizadas

- ASP.NET Core Razor Pages
- Entity Framework Core
- SQLite
- Bootstrap (para layout)

## Como rodar o projeto

1. **Clone o repositório**
   ```bash
   git clone <url-do-repositorio>
   cd CRUDaspnet
   ```

2. **Restaure os pacotes**
   ```bash
   dotnet restore
   ```

3. **Aplique as migrations e crie o banco de dados**
   ```bash
   dotnet ef database update
   ```

4. **Execute o projeto**
   ```bash
   dotnet run
   ```

5. **Acesse no navegador**
   ```
   http://localhost:5000
   ```

## Observações

- O banco de dados SQLite é criado automaticamente no arquivo `app.db` na primeira execução.
- Para visualizar ou editar o banco, utilize ferramentas como [DB Browser for SQLite](https://sqlitebrowser.org/) ou a extensão SQLite para VS Code.
- Caso utilize scaffolding, pode ser necessário instalar o pacote `Microsoft.EntityFrameworkCore.SqlServer` apenas para geração de código.

## Estrutura

```
CrudCsharp/
├── Models/
│   ├── Student.cs
│   └── Premium.cs
├── Pages/
│   ├── Students/
│   └── Premiums/
├── app.db
├── Startup.cs
└── ...
```

## Licença

Este projeto é livre para uso educacional.
