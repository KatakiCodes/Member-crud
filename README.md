# Member-Crud

## Sobre o Projeto

Esta é uma aplicação desenvolvida em .NET 9 e ASP.NET Core que tem como função a execução de um CRUD (Create, Read, Update, Delete) de Membros.

## Objetivo

O principal objetivo deste projeto é consolidar e praticar conceitos importantes do desenvolvimento .NET e ASP.NET Core, incluindo:

* Arquitetura Limpa.
* Padrão CQRS.
* MEDIATR.

## Como Executar a API (.NET 9 e ASP.NET Core)

A seguir, estão os passos e comandos necessários para executar uma API .NET 9 e ASP.NET Core recém baixada do GitHub em seu ambiente local.

### Pré-requisitos

* **SDK do .NET 9:** Certifique-se de ter o SDK do .NET 9 instalado em sua máquina. Você pode baixá-lo no site oficial da Microsoft.

### Passos e Comandos

1.  **Navegue até o diretório do projeto:** Abra o terminal ou prompt de comando e navegue até a pasta onde os arquivos do projeto foram clonados do GitHub. Por exemplo:

    ```bash
    cd member-crud
    ```

2.  **Restaure as dependências NuGet:** Este comando baixa todas as bibliotecas e pacotes necessários definidos no arquivo `.csproj` do seu projeto.

    ```bash
    dotnet restore
    ```

3.  **Construa o projeto:** Este comando compila o código da sua aplicação.

    ```bash
    dotnet build
    ```

4.  **Execute a aplicação:** Este comando inicia o servidor web Kestrel (servidor padrão do ASP.NET Core) e hospeda sua API.

    ```bash
    dotnet run
    ```

    Você deverá ver uma saída no terminal indicando que a aplicação está rodando e em qual(is) URL(s) ela está acessível (geralmente `http://localhost:5xxx`).

