# API REST para Lista de Tarefas com ASP.NET Core

![Status](https://img.shields.io/badge/status-conclu%C3%ADdo-brightgreen)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)

## 📖 Sobre o Projeto

Esta é uma API RESTful para gerenciar uma lista de tarefas (To-Do List), desenvolvida com C# e o framework ASP.NET Core. O projeto serve como uma introdução prática e fundamental ao desenvolvimento de backend no ecossistema .NET, cobrindo a criação de controllers, endpoints e o manuseio de requisições HTTP.

Para focar nos conceitos do framework, os dados são armazenados em uma lista em memória, sem a necessidade de um banco de dados externo.

---

## ✨ Funcionalidades

A API implementa as operações CRUD (Criar, Ler, Atualizar, Deletar) completas para as tarefas:

- **`GET /api/Tarefas`**: Lista todas as tarefas existentes.
- **`GET /api/Tarefas/{id}`**: Obtém os detalhes de uma tarefa específica pelo seu ID.
- **`POST /api/Tarefas`**: Cria uma nova tarefa.
- **`PUT /api/Tarefas/{id}`**: Atualiza uma tarefa existente.
- **`DELETE /api/Tarefas/{id}`**: Remove uma tarefa.
- **Documentação Interativa:** A API conta com uma interface Swagger (OpenAPI) para fácil visualização e teste dos endpoints.

---

## 🛠️ Tecnologias e Conceitos Praticados

- **C#**: Linguagem principal da aplicação.
- **ASP.NET Core Web API**: Framework para a construção de APIs.
- **Arquitetura MVC para APIs**: Organização do código em Models (`Tarefa.cs`) e Controllers (`TarefasController.cs`).
- **Roteamento e Atributos HTTP**: Uso de atributos como `[ApiController]`, `[Route]`, `[HttpGet]`, `[HttpPost]` para definir o comportamento da API.
- **Armazenamento de Dados em Memória**: Utilização de uma `List<T>` estática para simular um banco de dados.
- **Swagger/OpenAPI**: Geração automática de documentação interativa através do pacote `Swashbuckle.AspNetCore`.

---

## 🚀 Como Rodar o Projeto

### **Pré-requisitos**

- **.NET SDK** (versão 6.0 ou superior).

### **Instalação e Execução**

1.  **Clone o repositório**:
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
    ```

2.  **Navegue até a pasta do projeto**:
    ```bash
    cd TarefasApi
    ```
    
3.  **(Opcional) Adicione o pacote do Swagger se necessário**:
    ```bash
    dotnet add package Swashbuckle.AspNetCore
    ```

4.  **Execute a aplicação**:
    ```bash
    dotnet run
    ```

### Exemplo de Teste

Com o servidor rodando, acesse a documentação interativa no seu navegador para testar todos os endpoints. A URL será informada no terminal ao iniciar a aplicação.

- **Exemplo de URL do Swagger:** `http://localhost:5078/swagger`

---

## ✒️ Autor

**Guilherme**
