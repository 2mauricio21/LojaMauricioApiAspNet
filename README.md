# API de Loja em ASP.NET Core

Este projeto é uma API de loja desenvolvida em ASP.NET Core que gerencia três entidades principais: Fornecedor, Contrato e Produto.

## Funcionalidades

- **Autenticação com JWT Token:** A API possui um sistema de autenticação utilizando JWT Token.
- **Autenticação Necessária para Operações Específicas:** Para deletar um fornecedor, realizar um GET em contratos ou deletar um contrato, é necessário estar autenticado.
- **Cadastro de Usuários Mocado:**
  - **Usuário Admin:**
    - **ID:** 1
    - **Username:** admin
    - **Senha:** admin
    - **Roles:** manager
  - **Usuário Empregado:**
    - **ID:** 2
    - **Username:** empregado
    - **Senha:** empregado
    - **Roles:** employee

## Autenticação na API

- Para se autenticar, utilize o Swagger.
- O login no Swagger retornará um token.
- Para autenticar, vá para a seção de autenticação no Swagger e insira o token obtido anteriormente com a palavra Bearer antes(sem aspas) no campo "Bearer Token". Após isso, será possível fazer consultas.

## Endpoints Principais

### CRUD Fornecedor

- **Criar Fornecedor:** Método POST `/api/fornecedor`
- **Atualizar Fornecedor:** Método PUT `/api/fornecedor`
- **Deletar Fornecedor:** Método DELETE `/api/fornecedor/{id}`
- **Consultar Fornecedores:** Método GET `/api/fornecedor`
- **Consultar Fornecedor por ID:** Método GET `/api/fornecedor/{id}`
- Autenticação necessária para deletar, criar e atualizar: Sim

### CRUD Contrato

- **Criar Contrato:** Método POST `/api/contrato`
- **Atualizar Contrato:** Método PUT `/api/contrato`
- **Deletar Contrato:** Método DELETE `/api/contrato/{id}`
- **Consultar Contratos:** Método GET `/api/contrato`
- **Consultar Contrato por ID:** Método GET `/api/contrato/{id}`
- Autenticação necessária para deletar, criar e atualizar: Sim

### CRUD Produto

- **Criar Produto:** Método POST `/api/produto`
- **Atualizar Produto:** Método PUT `/api/produto`
- **Deletar Produto:** Método DELETE `/api/produto/{id}`
- **Consultar Produtos:** Método GET `/api/produto`
- **Consultar Produto por ID:** Método GET `/api/produto/{id}`
- Autenticação necessária para deletar, criar e atualizar: Sim

## Configuração do Banco de Dados

- O sistema é feito em Firestore. Para executar a solução, siga os passos abaixo:
  1. Crie o banco de dados no Firestore (gratuito).
  2. Baixe o arquivo de configuração gerado pelo Firestore.
  3. Coloque o arquivo de configuração na pasta raiz do projeto.
  4. No diretório "Utils", acesse o arquivo "Settings.cs".
  5. Para a variável "arquivoApikey", defina o nome do arquivo gerado pelo Firestore (algo como db-projeto-797d7-firebase-adminsdk-31mk9-bba77c5048).
  6. Para a variável "projectId", defina o nome do projeto criado no Firestore (algo como db-projeto-797d7).

## Como Executar o Projeto

- Clone este repositório.
- Abra o projeto em um ambiente de desenvolvimento (Visual Studio, Visual Studio Code, etc.).
- Execute a aplicação.

## Dependências

- ASP.NET Core
- JWT Authentication
- Firestore
- Swagger

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para propor melhorias, novas funcionalidades ou correções de bugs.
