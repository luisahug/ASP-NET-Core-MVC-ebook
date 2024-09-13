# Projeto de Cadastro de Universidades

## Descrição
Este é um projeto ASP.NET Core MVC ensinado pelo livro ASP.NET Core MVC - Aplicações modernas em conjunto com o Entity Framework, do Everton Coimbra de Araújo. O programa possibilita cadastrar instituições, departamentos, professores e alunos. 

### Funcionalidades
- Criação, edição, detalhamento e exclusão de instituições
- Criação, edição, detalhamento e exclusão de departamentos de instituições criadas
- Criação, edição, detalhamento e exclusão de acadêmicos com possibilidade de inserir e remover foto
- Criação, edição, detalhamento e exclusão de professores
- Cadastro de professores em cursos cadastrados no sistema
- Autenticação de usuário para acessar algumas páginas (as de Instituição)
- Criação de novos usuários
- Exibição de lista de cadastro de professor com um curso naquela sessão atual

## Como rodar a aplicação
- Clonar o repositório
    Link: https://github.com/luisahug/ASP-NET-Core-MVC-ebook.git
- Verifique se possui instalado:
    - .NET 8.0
    - SQL Server
    - Visual Studio 
    - pacotes utilizados:
        - MicrosoftApNetCore.Http.Features
        - Microsoft.AspNetCore.Identity.EntityFrameworkCore
        - Microsoft.AspNetCore.Session
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.Design
        - Microsoft.EntityFramkeworkCore.Relational
        - Microsoft.EntityFrameworkCore.SqlServer
        - Microsoft.VisualStudio.Web.CodeGeneration.Design
- O programa está pronto para ser rodado.

### Manutenção do banco de dados
- O que for preciso editar no banco de dados deve ser feito através dos arquivos da pasta Migrations. Qualquer alteração nesses arquivos exigirá que se exclua o banco de dados atual e atualize com o novo.
- Esse processo ocorre assim:
    - Dentro da pasta Capitulo01, no Explorador de Arquivos, na barra de busca digite cmd e abra a central de comando.
    - Insira os seguintes comandos:
        - dotnet ef database drop 
        - dotnet ef database update


